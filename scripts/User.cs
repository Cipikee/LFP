using System;
using System.Text;
using MongoDB.Bson;

public class User
{
    public ObjectId Id;
    public string Email;
    public string Username;
    public string Phone;
    public double Rating;
    public string[] Address = {"","",""};
    public byte[] Password;

    public User(string email, string username, string password)
    {
        Id = ObjectId.GenerateNewId();
        Email = email;
        Username = username;
        Password = ASCIIEncoding.ASCII.GetBytes(password);
        Rating = new Random().Next(10,50) / 10;
    }
}