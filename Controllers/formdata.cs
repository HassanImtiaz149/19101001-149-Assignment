using System;

public class Class1
{
	public form Setformdata(string fname, string lname, string email, int tel,string gen,
		string department)
	{
		Setformdata objj = new Setformdata();
		objj.fname = fname;
        objj.lname = lname;
		objj.email = email;
		objj.tel = tel;
		objj.gen = gen;
		objj.department = department;

		return (Setformdata)
	}
}
