using System;
using System.Runtime.InteropServices;

namespace Home_Class
{
    internal class Program
    {

        private static string ValidateString(string value, string propertyName)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException($"{propertyName} cannot be null or whitespace.");
            }
            return value;
        }

        class Website
        {
            private string name;
            private string url;
            private string title;
            private string ip;

            public string Name { get => name;
                set {
                    name = ValidateString(value, "name");
                }}
            public string Url { get => url; set {
                    url = ValidateString(value, "Url");
                } }
            public string Title { get => title; set {
                    title = ValidateString(value, "Title");
                } }
            public string IP { get => ip; }

            public Website(string name, string url, string title, string iP)
            {
                Name = name;
                Url = url;
                Title = title;
                ip = iP;
            }

            public override string ToString()
            {
                return $"Name: {Name}\nTitle: {Title}\nUrl: {Url}\nIP: {IP}";
            }
            public void Print()
            {
                Console.WriteLine(this.ToString());
            }
        }
        class Magazine
        {
            
            public string Name { get; set; }
            public int FoundingYear { get; set; }
            public string Description { get; set; }
            public string ContactPhone { get; set; }
            public string Email { get; set; }



            public Magazine(string name, int foundingYear, string description, string contactPhone, string email)
            {
                Name = name;
                FoundingYear = foundingYear;
                Description = description;
                ContactPhone = contactPhone;
                Email = email;
            }
            public override string ToString()
            {
                return $"Name: {Name}\nFounding Year: {FoundingYear}\nDescription: {Description}\nContactPhone: {ContactPhone}\nEmail: {Email}";
            }
            public void Print()
            {
                Console.WriteLine(this.ToString());
            }
        }

        public class Store
        {
            private string name;
            public string Name
            {
                get { return name; }
                set { name = ValidateString(value, "Name"); }
            }

            private string address;
            public string Address
            {
                get { return address; }
                set { address = ValidateString(value, "Address"); }
            }

            private string profileDescription;
            public string ProfileDescription
            {
                get { return profileDescription; }
                set { profileDescription = ValidateString(value, "Profile Description"); }
            }

            private string phoneNumber;
            public string PhoneNumber
            {
                get { return phoneNumber; }
                set { phoneNumber = ValidateString(value, "Phone Number"); }
            }

            private string email;
            public string Email
            {
                get { return email; }
                set { email = ValidateString(value, "Email"); }
            }

            public Store() { }

            public void EnterData()
            {
                Console.WriteLine("Enter Store Name:");
                Name = Console.ReadLine();

                Console.WriteLine("Enter Store Address:");
                Address = Console.ReadLine();

                Console.WriteLine("Enter Profile Description:");
                ProfileDescription = Console.ReadLine();

                Console.WriteLine("Enter Phone Number:");
                PhoneNumber = Console.ReadLine();

                Console.WriteLine("Enter Email:");
                Email = Console.ReadLine();
            }

            public void DisplayData()
            {
                Console.WriteLine($"Store Name: {Name}");
                Console.WriteLine($"Address: {Address}");
                Console.WriteLine($"Profile Description: {ProfileDescription}");
                Console.WriteLine($"Phone Number: {PhoneNumber}");
                Console.WriteLine($"Email: {Email}");
            }
        }



        static void Main(string[] args)
        {
            Website s = new Website("Some Site", "https://elevenlabs.io/speech-synthesis", "Speech Synthesis", "34.160.99.201");
            s.Name = "elevenlabs.io";
            Console.WriteLine(s.IP);
            s.Print();

            Magazine m = new Magazine("Nature Explorer", 1995, "A magazine dedicated to wildlife and nature conservation.", "+1-234-567-890", "info@natureexplorer.com");
            m.Print();

            Store st = new Store();
            st.EnterData();
            st.DisplayData();
        }
    }
}