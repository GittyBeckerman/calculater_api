about the project: this api of calculater. 

*************************************************************************
**Owner: Gitty Sterling
**
For any problem, I'd love for you to contact me:
Email: Gitty.sterling@gmail.com
Phone: 0527172552
*************************************************************************

Operating Instructions:
download the project to the computer, run locally,
The API will run on http://localhost:8000
Attached within the POSTMAN COLLECTION project named:
calculator.postman_collection with which you can easily run the transmitters
1. Run the project
2. Since the transmitters are required to arrive with a JWT, a transmitter must be run first
http://localhost:8000/token
Which will generate a JWT valid for 20 minutes
(name and password must be sent in the body)
3. Select the transmitter you wish to activate from:

##http://localhost:8000/calculate/add

##http://localhost:8000/calculate/subtract

##http://localhost:8000/calculate/divide

##http://localhost:8000/calculate/multiply

4. The JWT must be sent as a bearer token
5. Put 2 numerical values ​​in headers 2 (Number1, number2). Start the service.

There are also UNIT TEST for testing, it can be run through vs with test explorer


בעלים: גיטי שטרלינג לכל בעיה אשמח שתיצרו  קשר: 
מייל: Gitty.sterling@gmail.com
טלפון: 0527172552

הוראות הפעלה:
להוריד את הפרויקט למחשב, להריץ מקומית , 
הAPI ירוץ על http://localhost:8000
מצורף בתוך הפרויקט POSTMAN COLLECTION בשם: 
calculater.postman_collection שאיתו ניתן להריץ בקלות את השדרים
1. להריץ את הפרויקט 
2. היות שהשדרים נדרשים להגיע עם JWT  יש להריץ תחילה שדר 
http://localhost:8000/token 
אשר יצור JWT  עם תוקף ל20 דקות
(יש לשלוח בbody  שם וסיסמא)
3. בחר את השדר שאתה מעוניין להפעיל מתוך:

##http://localhost:8000/calculate/add

##http://localhost:8000/calculate/subtract

##http://localhost:8000/calculate/divide

##http://localhost:8000/calculate/multiply

4. יש לשלוח את הJWT כbearer token
5. לשים בheaders 2 (Number1, number2) 2 ערכים נומריים. הפעל את השירות.

ישנם גם UNIT TEST  לבדיקה, ניתן להפעיל דרך vs עם test explorer

# IO.Swagger - ASP.NET Core 2.0 Server

An API to perform basic arithmetic operations.

## Run

Linux/OS X:

```
sh build.sh
```

Windows:

```
build.bat
```



## Run in Docker - dont use it im not sure it works!!!!

```
cd src/IO.Swagger
docker build -t io.swagger .
docker run -p 5000:5000 io.swagger
```
