using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CustomDataInClass
{
    public struct PersonData
    {
        //can't have empty struct (parameterless)
        private int _id;
        public int ID { get { return _id; } set { _id = value; } }
        private string _name;
        public string NAME { get { return _name; } set { _name = value; } }
        private string _address;
        public string Address { get { return _address; } set { _address = value; } }
        private Prizes _prizes;
        public Prizes PRIZES { get { return _prizes; } set { _prizes = value; } }
    }
    public enum Prizes { Bronze_Medal, Gold_Medal, Silver_Medal, Brown_Medal }
    class Person
    {
        //get info PersonData. Note no inheritance
        //idea is to use the properties and values on Person Class from PersonData 
        //to the Person class. Done by implicit operator. make two class types same
        //pass parameter, means:
        //get all data from that object and access it here.
        public static implicit operator Person(PersonData data)
        {
            Person p = new Person();
            p.ID = data.ID;
            p.NAME = data.NAME;
            p.Address = data.Address;
            p.PRIZES = data.PRIZES;
            return p; //must return
        }
        //accept an object
        public static implicit operator Person(object[] data)
        {
            Person p = new Person();
            //example to follow {int,string, string, enum}
            if (data.Count() != 4)
            { //if data/object passing is less than 4 items
                Console.WriteLine("You must have at least 4 items on data. =>{0}"
                                    , data.Count());
            }else if( !( data[0] is int ) )
            { //if first element isn't int
                Console.WriteLine("First Element Must Be an Int for Id =>You entered {0}"
                                    , data[0].GetType().Name);
            }else if (!(data[1] is string) || !(data[2] is string))
            { //2nd and 2rd elements
                Console.WriteLine("Both Element 2 (name) and 3 (address) Must Be an string =>You entered {0} and {1}"
                                    , data[1].GetType().Name, data[2].GetType().Name);
            }else if(!(data[3] is Prizes))
            { //last element must be enum type of Prizes
                Console.WriteLine("First Element Must Be an Enum for Prizes =>You entered {0}"
                                    , data[3].GetType().Name);
            }else
            {
                p.ID = (int)data[0];//int
                p.NAME = (string)data[1];//string
                p.Address = (string)data[2];//string like address defined
                p.PRIZES = (Prizes)data[3]; //enum type
            }
            return p;
        }
        private int _id;

        public int ID { get { return _id; } set { _id = value; } }
        private string _name;

        public string NAME { get { return _name; } set { _name = value; } }
        private string _address;

        public string Address { get { return _address; } set { _address = value; } }
        private Prizes _prizes;
        public Prizes PRIZES { get { return _prizes; } set { _prizes = value; } }

        private string GetData()
        {
            this._id = ID;
            this._name = NAME;
            this._address = Address;
            this._prizes = PRIZES;
            return string.Format("ID: {0}\nName: {1}\nAddress: {2}\nPrizes: {3}\n"
                ,  _id, _name, _address, _prizes);
        }
        public void PrintData() { Console.WriteLine(GetData()); }
    }
}
