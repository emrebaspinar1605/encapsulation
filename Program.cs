using System;

namespace encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Student student1=new Student{
                Name="Emre",
                SurName="Başpınar",
                StuNo=1127,
                Clas=10
            };
            Student student2=new Student("Enes","Başpınar",1128,1);
            student1.GetStudentInformation();
            student1.Downgrade();
            student1.GetStudentInformation();
            student1.Upgrade();
            student1.GetStudentInformation();
            student2.GetStudentInformation();
            student2.Downgrade();

        }
    }
    class Student
    {
        private string name;
        private string surName;
        private int stuNo;
        private int clas;

        public string Name 
        { 
            get { return name;}
            set { name = value ;}
        }
        public string SurName { get => surName; set => surName = value; }
        public int StuNo { get => stuNo; set => stuNo = value; }
        public int Clas
        {
            get => clas;
            set 
            {
                if (value<1)
                {
                    Console.WriteLine("Sınıf En az 1 Olabilir");
                    clas=1;
                }
                clas=value;
            }
        }
        public Student(string name,string surName,int stuNo,int clas)
        {
            Name=name;
            SurName=surName;
            StuNo=stuNo;
            Clas=clas;
        }
        public Student(){}
        public void GetStudentInformation()
        {
            Console.WriteLine("******** Student İnformation ********");
            Console.WriteLine("Student Name              :{0}",this.Name);
            Console.WriteLine("Student Surname           :{0}",this.SurName);
            Console.WriteLine("Student Student Number    :{0}",this.StuNo);
            Console.WriteLine("Student Class             :{0}",this.Clas);
        }
        public void Upgrade()
        {
            Clas=Clas+1;
        }
        public void Downgrade()
        {
            if (Clas>1)
            {
                Clas=Clas-1;
            }
            Console.WriteLine("Dostum Daha ne kadar Sınıf düşebilir . Ana okulunamı gidecek");
            
        }
    }
}