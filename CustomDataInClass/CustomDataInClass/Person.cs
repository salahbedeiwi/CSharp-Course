using System;
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
