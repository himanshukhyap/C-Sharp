using System;


namespace Basic
{
     class Sample
    {
        public int h = 5;

        public string concateName(string fname,string middlename)
        {
            return fname + middlename;
        }
        public string concateName(string fname, int Lastname)
        {
            return fname;
        }

        public string concateName(string fname, string middlename, string lastName)
        {
            return fname + middlename+lastName;
        }


    }




    //concateNames(abc, b)
    //{

    //}
    //concateNames(abc, b,c)
    //{

    //}

}
