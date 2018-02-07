using System;
using Desk;

public class QuoteControl
{
    private Desk _desk;
    public QuoteControl(Desk desk)
	{

        _desk = desk;

	}


    private double calculatePrice()
    {



        double answer = 200;

        double sqInSize = _desk.width * _desk.depth;
        answer += (sqInSize) / 1000;
        answer += (_desk.drawers * 50);


        switch (_desk.surfaceType)
        {
            case "Laminated":
                answer += 100;
                break;
            case "Oak":
                answer += 200;
                break;
            case "Rosewood":
                answer += 300;
                break;
            case "Veneer":
                answer += 125;
                break;
            case "Pine":
                answer += 50;
                break;
        }

        //add in shipping cost
        switch (_desk.rushOrder)
        {
            case "No Rush":
                //no additional cose
                break;
            case "3 Day":
                if (sqInSize < 1000)
                {
                    answer += 60;
                }
                else if (sqInSize >= 1000 && sqInSize < 2000)
                {
                    answer += 70;
                }
                else
                {
                    answer += 80;
                }
                break;
            case "5 Day":
                if (sqInSize < 1000)
                {
                    answer += 40;
                }
                else if (sqInSize >= 1000 && sqInSize < 2000)
                {
                    answer += 50;
                }
                else
                {
                    answer += 60;
                }
                break;
            case "7 Day":
                if (sqInSize < 1000)
                {
                    answer += 30;
                }
                else if (sqInSize >= 1000 && sqInSize < 2000)
                {
                    answer += 35;
                }
                else
                {
                    answer += 40;
                }
                break;
        }

        return Math.Round(answer, 2);

    }

    private void saveQuote()
    {



        String csvpath = "quotes.txt";
        if (!File.Exists(csvpath))
        {
            File.CreateText(csvpath);
            Console.WriteLine("file created");
        }
        else
        {


            String tmp = "" + _desk.DateTime.Now.ToString() + "," + _desk.name + "," + _desk.price.ToString() + "," + _desk.surfaceType + "," + _desk.drawers.ToString() + "," + _desk.width.ToString() + "," + _desk.depth.ToString();

            StringBuilder csvcontent = new StringBuilder();
            csvcontent.AppendLine(tmp);
            File.AppendAllText(csvpath, csvcontent.ToString());
        }




    }
}
