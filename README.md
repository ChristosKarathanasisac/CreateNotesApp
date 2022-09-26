#  **smart .note** 

 ## Table of contents
* [Description](#description)
* [Setup](#setup)
* [Step by Step tutorial](#step-by-step-tutorial)
* [Application Videos](#application-videos)


  ## **Description**
  **smart .note** is an application for saving notes. The application is designed to run on a local network or simply on a PC. With the smart .note app you can create, store and manage notes. In order to use the app, users have to create a new account. After the registration users can create their notes. These notes can have attached files and photos. In addition to saving notes, the users can send them by email or save them locally on their PC. Furthermore, they can add a reminder on a certain date and time. On that day they will receive an email with their note.
  
  
  - I used C# and I created the app in Visual Studio 2019. Regarding the database, I used Microsoft SQL Server Management Studio 18. I chose that tools because they are free and very popular. Also in many cases, they are used in combination.
  - The main app is a Windows Form Application. Μainly consists of forms and some supporting classes which implement the connection with the database and some application operations (like sending email, downloading/uploading files, phone, and email validation).
  - To create the images on the forms I used Canva and I found the icons on IconScout.
  - For the function of the reminder, I used a windows service. This service runs in the background every minute and checks for notes that need to be sent. After collecting the notes it sends them using email to the users who created them.

 
  I created that project to :
  - Discover the features provided by windows forms and be familiar with them. 
  - Practice the managing of the registration and login forms.
  - Practice saving and retrieving files from a database.
  - Create a windows service.

  ## **Setup**
  ##### Microsoft SQL Server and Microsoft SQL Server Management Studio 18 are required to run the application.
 
  ##### Steps to run the application:
  - Open with SSMS 18 the .sql file you will find inside the
  [CREATENOTEDB.zip](https://github.com/ChristosKarathanasisac/CreateNotesApp/files/9632062/CREATENOTEDB.zip).
  - Replace the file paths to match those on your PC. (mdf and log files of the database will be stored in the path you choose).
  - Execute the query. 
  - Download the file [smart .note.zip](https://github.com/ChristosKarathanasisac/CreateNotesApp/files/9638231/smart.note.zip).
  - Enter the details of the server on which the application will run in the file WriteNotesApplication.exe.config.
  - The smart .note app is ready for use.
 
  ##### Steps to setup the reminder windows service:
  - Download the file [smart .note Reminder.zip](https://github.com/ChristosKarathanasisac/CreateNotesApp/files/9638237/smart.note.Reminder.zip).
  -  Enter the details of the server on which the application will run in the file ReminderWinService.exe.config. Additionally, create a new email account that the app will use to send reminders. (Τhe email I used has been deleted.)
  -  Create a shortcut from ReminderWinService.exe. In the shortcut properties change the destination by adding /install to the end.
  -  Run the shortcut as administrator. Now you can find ReminderWinService to the services.
  -  Start the service. (Τo have the functionality of the reminders in the application, the service must be running).
  


   ## **Step by Step tutorial**
     ### On the first page of the app, users have the options to log in or to create a new account.

    ![IntroForm](https://user-images.githubusercontent.com/95130533/190989494-5d138ea2-d414-4e79-ad89-8cc0675ff612.png)

     ### On the sing up page users can create a new account. The app:  
    - Checks that all required fields are completed.
    - Their email and phone validation. 
    - Check that the account doesn't exist and that passwords match.
    - Saves users to the database. The passwords saved are encrypted.

    ![Στιγμιότυπο οθόνης (42)](https://user-images.githubusercontent.com/95130533/191171210-92f5eac3-7e0f-4932-a757-f93482af8d42.png)

    ### Users after the successful creation of their account has the following options.
    
  ![Στιγμιότυπο οθόνης (44)](https://user-images.githubusercontent.com/95130533/191172739-b6349a35-6691-4815-88e0-29fe075157ce.png)

    ### The new note page has the following form. Users can:
  - Create new note. They can either write their note or use the voice function.
  - Αttach a file (pdf, excel, wotd) to their note.
  - Αttach images to their note. (Images must have max size 600x600px. Bigger images are not accepted by the app)
  - Add reminder on a certain date. On that day the user will receive a message from the application. The message will include the note, the topic, the attached files, and the attached images.

    - #### New note page.
   
     ![1](https://user-images.githubusercontent.com/95130533/191436888-74283813-bd25-430c-8485-6909ff726d9c.png)
    - #### Select images to attach.
   
     ![2](https://user-images.githubusercontent.com/95130533/191436910-6504491c-2805-4130-8d68-7246e61f54ba.png)
    - #### Note with images,file and reminder. The note is ready to save.
   
     ![3](https://user-images.githubusercontent.com/95130533/191436963-f6018b39-f239-4578-894b-c70702512de6.png)


   ### The second option users have is to search their notes. The users can filter their notes based on.
  - The creation date.
  - The last modified date.
  - Word(s).
  ### Of course, the users have the option to get all notes created by them.

  ![searchNote](https://user-images.githubusercontent.com/95130533/191441841-1ed2b52c-7166-4697-8b04-ac1f3de3724b.png)

    ### After the users finds their note have the following options:
    - #### They can open their note.
    - #### They can modify their note.
    - #### They can delete their note.
       
       
       #### On the open note page users can:
        - Save their note and the attachments on their personal computer.
        - Send their note and the attachments via email.
        - Open the saved file.
        - Open the saved images.
        
        ![openfullnote](https://user-images.githubusercontent.com/95130533/191449286-6f7f61fd-16a1-4fc2-91e5-d9eb3820efe0.png)
  
    

      #### On the modify note page users can:
        - Modify their note.
        - Modify a reminder.  
        - Add a reminder.
        - Delete a reminder.
        
      ![modifyNotes](https://user-images.githubusercontent.com/95130533/191453722-ba39f2b2-8a84-4a0a-a775-9bd8044f0160.png)

## **Application Videos**
https://user-images.githubusercontent.com/95130533/191725335-ea44ef19-a32d-43d9-a1ce-c6813ba17b9b.mp4







https://user-images.githubusercontent.com/95130533/191727430-63fa5228-73b0-4eea-92da-8d83bc450083.mp4


