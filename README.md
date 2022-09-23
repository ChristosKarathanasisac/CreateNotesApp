#  **smart .note** 

 ## Table of contents
* [Description](#description)
* [More Details](#more-details-with-screenshots)
* [Application Videos](#application-videos)
* [Setup](#setup)

  ## **Description**
  **smart .note** is an application for saving notes. The application is designed to run on a local network or simply on a PC.The basic functionality of the app is to   create, store and manage notes. Someone who wants to use the app, first of all, has to create o new account. After the registration user can create his notes. These   notes can have attached files and photos. In addition to saving notes, the user can send them by email or save them locally on his PC. Furthermore, the user can add   a reminder on a certain date and time. On that day he will receive an email with his note.
  
  
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
  ##### Microsoft SQL Server Management Studio 18 is required to run the application.
 
  ##### Steps to run the application:
  - Open with SSMS 18 the .sql file you will find inside the
  [CREATENOTEDB.zip](https://github.com/ChristosKarathanasisac/CreateNotesApp/files/9632062/CREATENOTEDB.zip).
  - Replace the file paths to match those on your PC.
  - Execute the query. 
  - Download the file 

  - Enter the details of the server on which the application will run in the file WriteNotesApplication.exe.config.
 




   ## **More details with screenshots**
     ### On the first page of the app, user has the options to log in or to create a new account.

    ![IntroForm](https://user-images.githubusercontent.com/95130533/190989494-5d138ea2-d414-4e79-ad89-8cc0675ff612.png)

     ### On the sing up page user can create a new account. The app:  
    - Checks that all required fields are completed.
    - Has email and phone validation. 
    - Check that the user doesn't exist and that passwords match.
    - Saves the user to the database. The passwords saved are encrypted.

    ![Στιγμιότυπο οθόνης (42)](https://user-images.githubusercontent.com/95130533/191171210-92f5eac3-7e0f-4932-a757-f93482af8d42.png)

    ### User after the successful creation of his account has the following options.
    
  ![Στιγμιότυπο οθόνης (44)](https://user-images.githubusercontent.com/95130533/191172739-b6349a35-6691-4815-88e0-29fe075157ce.png)

    ### The new note page has the following form. User can:
  - Create new note. He can either write his note or use the voice function.
  - Αttach a file (pdf, excel, wotd) to his note.
  - Αttach images to his note. (Images must have max size 600x600px. Bigger images are not accepted by the app).
  - To add reminder on a certain date. On that day user will receive a message from the application. The message will include the note, the topic, the attached files, and the attached images.

    - #### New note page.
   
     ![1](https://user-images.githubusercontent.com/95130533/191436888-74283813-bd25-430c-8485-6909ff726d9c.png)
    - #### Select images to attach.
   
     ![2](https://user-images.githubusercontent.com/95130533/191436910-6504491c-2805-4130-8d68-7246e61f54ba.png)
    - #### Note with images,file and reminder. The note is ready to save.
   
     ![3](https://user-images.githubusercontent.com/95130533/191436963-f6018b39-f239-4578-894b-c70702512de6.png)


   ### The second option a user has is to search his notes. The user can filter his notes based on.
  - The creation date.
  - The last modified date.
  - Word(s).
  ### Of course, the user has the option to get all notes created by him.

  ![searchNote](https://user-images.githubusercontent.com/95130533/191441841-1ed2b52c-7166-4697-8b04-ac1f3de3724b.png)

    ### After the user finds his note has the following options:
    - #### He can open his note.
    - #### He can modify his note.
    - #### He can delete his note.
       
       
       #### On the open note page user can:
        - Save his note and the attachments on his personal computer.
        - Send his note and the attachments via email.
        - Open the saved file.
        - Open the saved images.
        
        ![openfullnote](https://user-images.githubusercontent.com/95130533/191449286-6f7f61fd-16a1-4fc2-91e5-d9eb3820efe0.png)
  
    

      #### On the modify note page user can:
        - Modify his note.
        - Modify a reminder.  
        - Add a reminder.
        - Delete a reminder.
        
      ![modifyNotes](https://user-images.githubusercontent.com/95130533/191453722-ba39f2b2-8a84-4a0a-a775-9bd8044f0160.png)

## **Application Videos**
https://user-images.githubusercontent.com/95130533/191725335-ea44ef19-a32d-43d9-a1ce-c6813ba17b9b.mp4







https://user-images.githubusercontent.com/95130533/191727430-63fa5228-73b0-4eea-92da-8d83bc450083.mp4


