using System.Security.Cryptography.X509Certificates;
using System;
using assingment_OOP04.Intertfaces;
using assingment_OOP04;

namespace assigment_oop04

{
    public class Program
    {
        public static void Main(string[] args)
        {

            #region PART 1

            #region "Question 1"
            //What is the primary purpose of an interface in C#?
            //Answer: b) To define a blueprint for a class
            #endregion

            #region "Question 2"
            //  Which of the following is NOT a valid access modifier for interface members in C#?
            //  Answer: a) private 
            //  Answer: b) protected
            #endregion

            #region "Question 3"
            // Can an interface contain fields in C#?
            // Answer: b) No
            #endregion

            #region "Question 4"
            // In C#, can an interface inherit from another interface?
            //Answer: b) Yes, interfaces can inherit from multiple interfaces
            #endregion

            #region "Question 5"
            //  Which keyword is used to implement an interface in a class in C#?
            //  Answer: d) implements
            #endregion

            #region "Question 6"
            //  Can an interface contain static methods in C#?
            //  Answer: a) Yes
            #endregion

            #region "Question 7"
            //  In C#, can an interface have explicit access modifiers for its members?
            //  Answer: b) No, all members are implicitly public
            #endregion

            #region "Question 8"
            //   What is the purpose of an explicit interface implementation in C#?
            //   Answer: a) To hide the interface members from outside access
            #endregion

            #region "Question 9"
            //    In C#, can an interface have a constructor?
            //   Answer: b) No, interfaces cannot have constructors
            #endregion

            #region "Question 10"
            //  How can a C# class implement multiple interfaces?
            //  Answer: c) By separating interface names with commas (:)
            #endregion

            #endregion

            #region PART 2 

            #region Question 1
            ICircle circle = new Circle(25);

            IRectangle rectangle = new Rectangle(5, 5);

            circle.DisplayShapeInfo();
            rectangle.DisplayShapeInfo();
            #endregion

            #region Question 2 

            
            IAuthenticationService authService = new BasicAuthenticationService();

            // authenticate the user
            string username = "user1";
            string password = "password1";
            bool isAuthenticated = authService.AuthenticateUser(username, password);
            Console.WriteLine($"User '{username}' authenticated: {isAuthenticated}");

            // Authorize the user
            string role = "admin";
            bool isAuthorized = authService.AuthorizeUser(username, role);
            Console.WriteLine($"User '{username}' authorized for role '{role}': {isAuthorized}");
            #endregion

            #region Question 3
            // declare the varibles : 
            string recipient = "hesham@gmail.com";
            string message = "this is a test notification";

            // test the output :    
            INotificationService emailService = new EmailNotificationService();
            emailService.SendNotification(recipient, message);

            INotificationService SmsService = new SmsNotificationService();
            SmsService.SendNotification(recipient, message);

            INotificationService pushNotification = new PushNotificationService();
            pushNotification.SendNotification(recipient, message);
            #endregion

            #endregion

        }
    }
}



