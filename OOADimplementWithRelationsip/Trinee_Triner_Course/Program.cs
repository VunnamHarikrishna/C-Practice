using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trinee_Triner_Course
{
    class Program
    {
        static void Main(string[] args)
        {
            
           
            Module Modublobj = new Module();
            Technology technologyobj = new Technology();
            Course courseobj = new Course();
            Trinings triningsobj = new Trinings();
            Trainer trainerobj = new Trainer();
            Trainee traineeobj = new Trainee();


            //topics data
            Topic Topic1 = new Topic();
            Topic Topic2 = new Topic();
            Topic Topic3 = new Topic();
            Topic Topic4 = new Topic();
            Topic Topic5 = new Topic();
            Topic Topic6 = new Topic();
            Topic Topic7 = new Topic();
            Topic Topic8 = new Topic();
            Topic Topic9 = new Topic();
            Topic Topic10 = new Topic();

            Topic1.TopicName = "data types";
            Topic3.TopicName = "array";
            Topic2.TopicName = "varibles ";
            Topic4.TopicName = "Exception";
            Topic5.TopicName = "Collections";
            Topic6.TopicName = "Function";
            Topic7.TopicName = "Stracture";
            Topic8.TopicName = "strings ";
            Topic9.TopicName = "deligates";
            Topic10.TopicName = "layered architecture";

            //add topics to units
            Unit Unit1 = new Unit();
            Unit Unit2 = new Unit(); 
            Unit Unit3 = new Unit(); 
            Unit Unit4 = new Unit(); 
            Unit Unit5 = new Unit();

            Unit1.UnitNo = 1;
            Unit1.UnitName = "unit1";
            Unit1.SetTopics(Topic1);
            Unit1.SetTopics(Topic2);


            Unit2.UnitNo = 2;
            Unit2.UnitName = "unit2";
            Unit2.SetTopics(Topic3);
            Unit2.SetTopics(Topic4);


            Unit3.UnitNo = 3;
            Unit3.UnitName = "unit3";
            Unit3.SetTopics(Topic5);
            Unit3.SetTopics(Topic6);


            Unit4.UnitNo = 4;
            Unit4.UnitName = "unit4";
            Unit4.SetTopics(Topic7);
            Unit4.SetTopics(Topic8);


            Unit5.UnitNo = 5;
            Unit5.UnitName = "unit5";
            Unit5.SetTopics(Topic9);
            Unit5.SetTopics(Topic10);

            //add module
            Module module1 = new Module();
            Module module2 = new Module();
            Module module3 = new Module();

            module1.ModuleName = "module1";
            module1.setUnits(Unit1);
            module1.setUnits(Unit2);
            
            module2.ModuleName = "module2";
            module2.setUnits(Unit3);
            module2.setUnits(Unit4);

            module3.ModuleName = "module3";
            module3.setUnits(Unit5);

            //add course
            Course Course1 = new Course();
            Course Course2 = new Course();
            Course Course3 = new Course();

            Course1.CourseID = 1;
            Course1.CourseName = "course1";
            Course1.Technology = "Programing1";
            Course1.setModulelist(module1);


            Course2.CourseID = 2;
            Course2.CourseName = "course2";
            Course2.Technology = "Programing1";
            Course2.setModulelist(module2);


            Course3.CourseID = 3;
            Course3.CourseName = "course3";
            Course3.Technology = "Programing1";
            Course3.setModulelist(module3);
            

            // technology dara
            Technology Technologyobj = new Technology();
            technologyobj.TechnologyId = 1;
            technologyobj.TechnologyName = "Programing1";
            technologyobj.SetCources(Course1);
            technologyobj.SetCources(Course2);
            technologyobj.SetCources(Course3);

            //trining objs
            Trinings trining1 = new Trinings();
            Trinings trining2 = new Trinings();
            Trinings trining3 = new Trinings();

            // Trainer objs
            Trainer trainer1 = new Trainer();
            Trainer trainer2 = new Trainer();
            Trainer trainer3 = new Trainer();

            // trinee objs
            Trainee Trainee1 = new Trainee();
            Trainee Trainee2 = new Trainee();
            Trainee Trainee3 = new Trainee();
            Trainee Trainee4 = new Trainee();
            Trainee Trainee5 = new Trainee();

            Trainee1.TrineeName = "trine1";
            Trainee1.TraineeID = 1;
            Trainee1.TrinerName = "triner1";
            Trainee1.TriningsAdd(trining1);

            Trainee2.TrineeName = "trine2";
            Trainee2.TraineeID = 2;
            Trainee2.TrinerName = "triner2";
            Trainee2.TriningsAdd(trining1);

            Trainee3.TrineeName = "trine3";
            Trainee3.TraineeID = 3;
            Trainee3.TrinerName = "triner3";
            Trainee3.TriningsAdd(trining2);

            Trainee4.TrineeName = "trine4";
            Trainee4.TraineeID = 4;
            Trainee4.TrinerName = "triner4";
            Trainee4.TriningsAdd(trining3);

            Trainee5.TrineeName = "trine5";
            Trainee5.TraineeID = 5;
            Trainee5.TrinerName = "triner5";
            Trainee5.TriningsAdd(trining3);
                    //
            trining1.TriningID = 1;
            trining1.TringingName = "trining1";
            trining1.Trinerdata = "triner1";
            trining1.Coursedata = "couse1";

            trining2.TriningID = 2;
            trining2.TringingName = "trining2";
            trining2.Trinerdata = "triner2";
            trining2.Coursedata = "couse2";

            trining3.TriningID = 3;
            trining3.TringingName = "trining3";
            trining3.Trinerdata = "triner3";
            trining3.Coursedata = "couse3";

                        //
            trainer1.TrinerID = 1;
            trainer1.TrinerName = "triner1";
            trainer1.settrinees(Trainee1);
            trainer1.settrinees(Trainee2);
            trainer1.settrininglist(trining1);

            trainer2.TrinerID = 2;
            trainer2.TrinerName = "triner2";
            trainer2.settrinees(Trainee3);
            trainer2.settrinees(Trainee4);
            trainer2.settrininglist(trining2);

            trainer3.TrinerID = 3;
            trainer3.TrinerName = "triner3";
            trainer3.settrinees(Trainee5);
            trainer3.settrininglist(trining3);


            List<Trainee> trinelist = new List<Trainee>();





            Console.ReadLine();
        }
    }
}
