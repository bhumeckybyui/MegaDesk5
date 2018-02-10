using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk
{
    class SaveQuote
    {

        private Desk _desk;
        public double price;

        public SaveQuote(Desk desk)
        {
            _desk = desk;
            
            price = calculatePrice();
            _desk.price = price;
            _desk.date = DateTime.Now.ToString();
            saveQuote();
            makejsonFile();
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


                String tmp = "" + DateTime.Now.ToString() + "," + _desk.name + "," + _desk.price.ToString() + "," + _desk.surfaceType + "," + _desk.width.ToString() + "," + _desk.depth.ToString() + "," + _desk.drawers.ToString() + "," + price.ToString();

                StringBuilder csvcontent = new StringBuilder();
                csvcontent.AppendLine(tmp);
                File.AppendAllText(csvpath, csvcontent.ToString());
                csvcontent.Clear();
                
                
            }




        }

        private void makejsonFile()
        {

            //makes the file if not there then, make an object for Quotes addds to the Quote Stack, then pushes that into JSON quotes file
            //OR reads from file, push that into a new object of Quotes, 
            //use that object file to add NEW Quote
            //Save the updated Quote Object into json File
            //.. distroy Quotes object

            String jsonFile = "quotes.json";
            if (!File.Exists(jsonFile))
            {
                //making new file
                //File.CreateText(jsonFile);
                
                //make to Quotes Object class
                
                Quotes q = new Quotes();
                q.addQuote(_desk);
                File.WriteAllText(@jsonFile, JsonConvert.SerializeObject(q));


            }
            else
            {
                //already have the file

                String line;
                try
                {
                    StreamReader file = new StreamReader(@"quotes.json");
                    Quotes q = null;
                    while ((line = file.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                        //Console.WriteLine(line
                        q = JsonConvert.DeserializeObject<Quotes>(line);
                        //File.CreateText(@"quotes.json", JsonConvert.SerializeObject(q));
                    }
                    file.Close();
                    if (q != null)
                    {
                        //add new quot to quote stack
                        q.addQuote(_desk);
                        //write all the info to json file
                        File.WriteAllText(@"quotes.json", JsonConvert.SerializeObject(q));

                        //clear out memory
                        q = null;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }


        }

    }


}
