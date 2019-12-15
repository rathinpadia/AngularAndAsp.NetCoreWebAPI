There are 2 Main projects :
1. Angular (AngularTraining)
2. Web API 
  a: TrainingWebAPI ->  API that communicates to angular project
  b: TrainingWebAPI.IntegrationTests -> Integration test to get and post data to the database via Web API
 
 1. Angular Project details
  a: UI to accept Training Name, Start Date and End Date from the user.
  b: Validation of end date greater than start date
  c: disable submit button if all the mandatory items are not filled
  d: Show a message to the user if data is saved successfully in the database and show date difference in days between the dates.
    
 2. Web API 
  a: code first approach to create database and tables
  b: post training details to db 
  c: get trainings from db
  d: Dependency Injection at service and controller
  e. used CORS to access the web api from Angular Project
  
 3. IntegrationTests
  a: create test case to fetch to call the web api controller by using http client
  b: create test case to add data to database by using web api control by using http client
