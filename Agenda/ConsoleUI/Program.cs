using Bussiness.Concrete;
using DataAccess.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            DairyManager dairyManager = new DairyManager(new EfDairyDal());
            Dairy dairy1 = new Dairy();
          


            int number;
            bool isValidInput = false;
            DateTime realDateInput;
            bool isValidDate = false;
            bool isValidDateShow = false;
            DateTime  realShowDateInput;
            bool isValidDeletedDate = false;
            DateTime realDateInputDeleted;
            bool isValidUpdateDate = false;
            DateTime realDateInputUpdate;
            bool isValidUpdatedDate = false;
            DateTime realDateInputUpdated;
                        


                while (!isValidInput)
            {
                Console.WriteLine("---------Welcome to Agenda--------" +
                "\n Press 1 to add an event to the Dairy. " +
                "\n Press 2 to delete an event in the Dairy. " +
                "\n Press 3 to update an event in the Dairy. " +
                "\n Press 4 to list the events " +
                "\n Press 5 to see a spesific event by date");
                

                string input = Console.ReadLine();

                if (int.TryParse(input, out number) && (number >= 1 && number <= 5))
                {
                    // Geçerli bir giriş yapıldığında döngüyü kır
                    isValidInput = true;
                }
                else
                {
                    // Geçersiz bir giriş yapıldığında uyarı ver
                    Console.WriteLine("Invalid entry");
                }

                if (number == 1)
                    
                {
                     
                
                   


                    while (!isValidDate)
                    {
                        Console.WriteLine(" Please enter the date of the event. Format= yyyy-mm-dd" );
                        string dateInput = Console.ReadLine();

                        if (DateTime.TryParseExact(dateInput,"yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out realDateInput))
                        {                           
                            isValidDate = true;
                            dairy1.DateTime = realDateInput;
                        }
                        else
                        {
                            Console.WriteLine("Invalid entry");
                        }
                    }


                       Console.WriteLine(" Please enter the topics to study of the event");
                       string topicInput = Console.ReadLine();
                       Console.WriteLine(" Please enter sources of the event");
                       string sourceInput = Console.ReadLine();
                       Console.WriteLine(" Please enter the note of the event");
                       string noteInput = Console.ReadLine();
   
                        dairy1.TopicToStudy = topicInput;
                        dairy1.Sources = sourceInput;
                        dairy1.Notes = noteInput;
                       
                        dairyManager.Add(dairy1);
 
                }
                if (number==2)
                {
                   
                    while (!isValidDeletedDate)
                    {
                         Console.WriteLine("Please enter the date of the event you want to delete. Format= yyyy-mm-dd");

                        string dairyDeleted = Console.ReadLine();
                       

                        if (DateTime.TryParseExact(dairyDeleted, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out realDateInputDeleted))
                        {
                            isValidDeletedDate = true;
                            Dairy inputWillDelete= dairyManager.GetOrderByDate(realDateInputDeleted);
                            dairyManager.Delete(inputWillDelete);

                           
                            
                        }
                        else
                        {
                            Console.WriteLine("Invalid entry");
                        }
                    }

                    
                }
                if (number==3)
                {
                    Dairy inputWillUpdate = null;

                    while (!isValidUpdateDate)
                    {
                        Console.WriteLine("Please enter the date of the event you want to be updated. Format= yyyy-mm-dd");
                        string dateInputUpdate = Console.ReadLine();
                        if (DateTime.TryParseExact(dateInputUpdate, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out realDateInputUpdate))
                        {

                            isValidUpdateDate = true;
                               inputWillUpdate = dairyManager.GetOrderByDate(realDateInputUpdate);
                              

                            


                        }
                        else
                        {
                            Console.WriteLine("Invalid entry");
                            
                        }

                    }
                    



                  
                    
                    while (!isValidUpdatedDate)
                    {
                        Console.WriteLine("Please enter the new date of your event.");
                        string dateInputUpdated = Console.ReadLine();
                        if (DateTime.TryParseExact(dateInputUpdated, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out realDateInputUpdated))
                        {
                            
                            isValidUpdatedDate = true;

                            inputWillUpdate.DateTime = realDateInputUpdated; 
                            

                        }
                        else
                        {
                            Console.WriteLine("Invalid entry");
                        }

                    }
                    

                    Console.WriteLine("Please enter the new topics to study of event.");
                    string inputTopicUpdate = Console.ReadLine();
                    inputWillUpdate.TopicToStudy = inputTopicUpdate;

                    Console.WriteLine("Please enter the new sources of the event.");
                    string inputSourcesUpdate = Console.ReadLine();
                    inputWillUpdate.Sources = inputSourcesUpdate;

                    
                    Console.WriteLine("Please enter the new notes of the event");
                    string inputNotesUpdate = Console.ReadLine();
                    inputWillUpdate.Notes = inputNotesUpdate;
                    dairyManager.Update(inputWillUpdate);

                }






                if (number == 4)
                {
                    Console.WriteLine("------- EVENT lIST --------");

                    foreach (var dr in dairyManager.GetAll())
                    {
                        

                        Console.WriteLine("Date of event ==> "+ dr.DateTime);
                        Console.WriteLine("Topics you will study at the event ==> " + dr.TopicToStudy);
                        Console.WriteLine("Sources of your event ==> " + dr.Sources);
                        Console.WriteLine("Notes of your event ==> " + dr.Notes);
                        Console.WriteLine("");
                       
                    }
                }
                if (number==5)
                {
                    while (!isValidDateShow)
                    {
                        Console.WriteLine(" Please enter the date of the event. Format= yyyy-mm-dd");
                        string showDateInput = Console.ReadLine();

                        if (DateTime.TryParseExact(showDateInput, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out realShowDateInput))
                        {
                            isValidDateShow = true;
                            
                            Dairy dairyShow = dairyManager.GetOrderByDate(realShowDateInput);
                            if (dairyShow != null)
                            {
                                Console.WriteLine("--------YOUR EVENT ON " + dairyShow.DateTime+"--------");
                                Console.WriteLine("Date of event ==> " + dairyShow.DateTime);
                                Console.WriteLine("Topics you will study at the event ==> " +  dairyShow.TopicToStudy);
                                Console.WriteLine("Sources of your event ==> " + dairyShow.Sources);
                                Console.WriteLine("Notes of your event ==> " + dairyShow.Notes);
                                Console.WriteLine("");


                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid entry");
                        }

                    }

                }



            }


               
         







            Console.ReadKey();
        }

    }
}
