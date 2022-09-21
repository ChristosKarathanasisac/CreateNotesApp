#  **smart .note** 

## **General Info**
- **smart .note** is an application for saving notes. The application is designed to run in a local network and provide options like new note creation, adding reminders, upload/download files and senting notes and files via email. I used C# and I created the app in Visual Studio 2019. Regarding the database I used Microsoft SQL Server Management Studio 18.

- I created that project to discover the features provided by windows forms and be familiar with them. 
- How to run the project.

## **More Details**
#### On the first page of the app, user has the options to log in or to create a new account.

![IntroForm](https://user-images.githubusercontent.com/95130533/190989494-5d138ea2-d414-4e79-ad89-8cc0675ff612.png)

##### On the sing up page user can create a new account. The app:  
- Checks that all required fields are completed.
- Has email and phone validation. 
- Check that the user doesn't exist and that passwords match.
- Saves the user to the database. The passwords saved are encrypted.

![Στιγμιότυπο οθόνης (42)](https://user-images.githubusercontent.com/95130533/191171210-92f5eac3-7e0f-4932-a757-f93482af8d42.png)

#### User after the successful creation of his account has the following options.
![Στιγμιότυπο οθόνης (44)](https://user-images.githubusercontent.com/95130533/191172739-b6349a35-6691-4815-88e0-29fe075157ce.png)

#### The new note page has the following form. User can:
- Create new note. He can either write his note or use the voice function.
- Αttach a file (pdf, excel, wotd) to his note.
- Αttach images to his note. (Images must have max size 600x600px. Bigger images are not accepted by the app).
- To add reminder on a certain date. On that day user will receive a message from the application. The message will include the note, the topic, the attached files, and the attached images.

#### New note page.
![1](https://user-images.githubusercontent.com/95130533/191436888-74283813-bd25-430c-8485-6909ff726d9c.png)
#### Select images to attach.
![2](https://user-images.githubusercontent.com/95130533/191436910-6504491c-2805-4130-8d68-7246e61f54ba.png)
#### Note with images,file and reminder. The note is ready to save.
![3](https://user-images.githubusercontent.com/95130533/191436963-f6018b39-f239-4578-894b-c70702512de6.png)








