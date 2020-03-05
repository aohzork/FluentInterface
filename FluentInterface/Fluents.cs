//using system;
//using system.collections.generic;
//using system.linq;
//using system.text;
//using system.threading.tasks;

//namespace fluentinterface
//{
//    //class wrapping
//    public class customer
//    {
//        private string _fullname;
//        public string fullname
//        {
//            get { return _fullname; }
//            set { _fullname = value; }
//        }
//        private datetime _dob;
//        public datetime dob
//        {
//            get { return _dob; }
//            set { _dob = value; }
//        }
//        private string _address;
//        public string address
//        {
//            get { return _address; }
//            set { _address = value; }
//        }

//    }

//    public class customerfluent
//    {
//        private customer obj = new customer();
//        public customerfluent nameofcustomer(string name)
//        {
//            obj.fullname = name;
//            return this;
//        }
//        public customerfluent bornon(string dob)
//        {
//            obj.dob = convert.todatetime(dob);
//            return this;
//        }
//        public void staysat(string address)
//        {
//            obj.address = address;

//        }
//    }


//    //fluent interface
//    public interface iname
//    {
//        iage withname(string name);
//    }

//    public interface iage
//    {
//        ipersist withage(int age);
//        ipersist expecteddeath(int age);
//    }

//    public interface ipersist
//    {
//        void save();
//    }

//    public class person : iname, iage, ipersist
//    {

//        public string name { get; private set; }
//        public int age { get; private set; }

//        private person()
//        {
//        }

//        public static iname create()
//        {
//            return new person();
//        }

//        public iage withname(string name)
//        {
//            name = name;
//            return this;
//        }

//        public ipersist withage(int age)
//        {
//            age = age;
//            return this;
//        }

//        public ipersist expecteddeath(int age)
//        {
//            age = age;
//            return this;
//        }

//        public void save()
//        {
//            // save changes here
//            console.writeline("name is :" + name);
//            console.writeline("age is :" + age);
//            console.writeline("save called");
//        }
//    }



//    class program
//    {
//        static void main(string[] args)
//        {

//            customerfluent customer = new customerfluent();
//            customer.bornon("2000/01/01").nameofcustomer("johannes").staysat("alle");


//            person.create().withname("hello").expecteddeath(5).save();
//            console.readkey();

//        }
//    }
//}
