using System;
using System.Collections;

using namespace Emergency_Ammbulance_Service
{ 
class person
{
    protected string name, address;
    protected int CNIC, phone;
    person(string name,int phone,string address, int cnic)
    {
        this.name = name;
        this.address = address;
        this.CNIC = cnic;
        this.phone = phone;
    }

}
class CTWO:person
{
    private int shift;
    private ArrayList Cases = new ArrayList(Case);
    
}
class Location
{
    private int logitude, latitude;
    Location(int longitude, int latitude)
    {
        this.logitude = longitude;
        this.latitude = latitude;
    }
    public void getLongitude()
    {
        return this.logitude;
    }
    public void getLatitude()
    {
        return this.latitude;

    }
}
class Hospital
{
    private string Name;
    private Location Located;
    private int room, bed;
    Hospital(string name, Location locatedAt, int room, int bed)
    {
        this.Name = name;
        this.Located = locatedAt;
        this.room = room;
        this.bed = bed;
    }


}
class Case
{
    private bool verified;
    private patient patient;
    
    private Hospital evacuatedTo;
    private Caller caller;
    private Location occuredAt;
    


}
class Patient:person
{
    private Caller reportedBy;
    private int RelativeContact;
    private Hospital admittedTO;

}
class Caller : person
{
    private int phoneNumber
    {
        get; set;
    }
    private Location location
    {
        get; set;
    }

}
class Call
{
    private int ID
    {
        get; set;
    }
    private Caller caller
    {
        get; set;
    }
    private int duration
    {
        get; set; 
    }
    private DateTime date
    {
        get; set;
    }
}
class Driver
{
    private string status
    {   get; set;    }
    private int shift
    { get; set; }
}

}