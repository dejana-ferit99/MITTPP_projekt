# MITTPP_projekt

This project is made for Methods and techniques of software support testing course.

For testing we were using [eKupi webshop](https://www.ekupi.hr/).

![alt text](https://superponude.com/web/wp-content/uploads/2015/04/ekupi-hr.jpg)

### Used softwares

- Visual Studio 
- Katalon Recorder
- Katalon Studio
- Google search

## Katalon Recorder & Studio - Selenium test generator
![alt text](https://automated-360.com/wp-content/uploads/2017/10/logo-katalon.png) \
Katalon Recorder is used for recording test cases. Katalon Studio performs test cases execution and allows exporting test cases in C#(WebDriver+NUnit) format suitable for further testing in Visual Studio.

## Visual Studio

If in order to use testing cases that are inported from Katalon Studio, we need to add these NuGet packages:
- NUnit framework
- Selenium WebDriver 
- Selenium Support
- Nunit3 Test Adapter 
- Selenium WebDriver – Gecko Driver

## Process
- Firstly, we need to prepare softwares that we'll be using. 
- After that, we need to see what are the elements that should be tested and write documentation for test cases that we will be executing. 
- Install Katalon Recorder browser plug in for Google search, other search engines couuld also be used such as Mozilla Firefox.
- We will start Katalon Recorder. Click "Record" button to start recording session and now we have to do all the steps that need to be done in order to complete the action that we want to test. After we are done, stop recording.
- We will check the steps and run script.
- Scritp needs to be exported in C# format.
- Now, we will open Visual Studio and we have to create C# Unit Test (.NET Framework) project.
- After opening Visual Studio, follow these steps: Project -> Manage NuGet Packages and install:
  - NUnit framework 
  - Selenium WebDriver 
  - Selenium Support
  - Nunit3 Test Adapter 
  - Selenium WebDriver – Gecko Driver 
- In UnitTest class add exported tests.
- Follow these steps:
  - Click on Build -> Build Solution
  - Click on Test -> Test Explorer
  - Run tests
  
## Test cases
- Here, we will describe all test cases
1) LOG IN
  - this case tests the site's behavior when logging in to an already registered user
  
  | Step | Action |
| ------ | ------ |
| Preconditions | User has profile |
| 1 | Go to URL [https://www.ekupi.hr/]|
| 2 | Click on "Prijava/Registracija" |
| 3 | In section Postojeći kupac enter Email adresa |
| 4 | In section Postojeći kupac enter Lozinka |
| 5 | Click on "Prijavi se" |
| Expected | User is Logged in |

2) LOG OUT
  - this case tests the site's behavior when user is logging out
  
  | Step | Action |
| ------ | ------ |
| Preconditions | User is logged in |
| 1 | Go to URL [https://www.ekupi.hr/]|
| 2 | Click on "Odjavite se" |
| Expected | User is Logged in |

3) Phange password
  - this case tests the site's behavior when user wants to change accounts password
  
  | Step | Action |
| ------ | ------ |
| Preconditions | User is logged in |
| 1 | Go to URL [https://www.ekupi.hr/]|
| 2 | Click on "Moj profil" |
| 3 | Click on "Promjena lozinke" |
| 3 | In section "Ažurirajte lozinku" enter Trenutna lozinka |
| 4 | In section "Ažurirajte lozinku" enter Lozinka |
| 5 | In section "Ažurirajte lozinku" enter Potvrdite lozinka |
| 6 | Click on "Ažuriranje" |
| Expected | Password is changed |  

4) Subscribe to newsletter
  - this case tests the site's behavior when user wants to subscribe to newsletter
  
  | Step | Action |
| ------ | ------ |
| 1 | Go to URL [https://www.ekupi.hr/]|
| 2 | Scroll down to footer |
| 3 | In section Prijavite se na besplatni newsletter enter Vaše ime |
| 3 | In section Prijavite se na besplatni newsletter enter Vaša email adresa |
| 4 | In section Prijavite se na besplatni newsletter enter Broj telefona |
| 5 | In section "Ažurirajte lozinku" enter Potvrdite lozinka |
| 6 | Click on "Prijavite se" |
| Expected | User is subscribed to newsletter |  

5) Add item in cart
  - this case tests the site's behavior when user add item in cart
  
  | Step | Action |
| ------ | ------ |
| 1 | Go to URL [https://www.ekupi.hr/]|
| 2 | Click on "Računala" tab |
| 3 | Scroll down |
| 3 | Click on first item offered |
| 4 | Click on "Dodajte u košaricu" |
| 5 | Click on "Dovršite kupovinu" |
| Expected | Item is successfully added in cart |  

5) Add item in cart
  - this case tests the site's behavior when user add item in cart
  
  | Step | Action |
| ------ | ------ |
| 1 | Go to URL [https://www.ekupi.hr/]|
| 2 | Click on "Računala" tab |
| 3 | Scroll down |
| 3 | Click on first item offered |
| 4 | Click on "Dodajte u košaricu" |
| 5 | Click on "Dovršite kupovinu" |
| Expected | Item is successfully added in cart |  

7) Search
  - this case tests the site's search engine
  
  | Step | Action |
| ------ | ------ |
| 1 | Go to URL [https://www.ekupi.hr/]|
| 2 | Click on search bar |
| 3 | Enter item name: "Miš" |
| 3 | Click on search button |
| 4 | In section "Sortiranje po" click on RELEVENTNOST |
| 5 | Choose "Cijeni (prvo najniža)" |
| Expected | List of items containing enterd word in ascending order | 

## Author
[@dejana-ferit99](https://github.com/dejana-ferit99)
