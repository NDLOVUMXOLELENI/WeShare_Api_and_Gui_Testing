# WeShare: A Social Expense Tracker
* The Api can be found here: http://localhost:5050/swagger and the web app: http://localhost:5050/

## Requiments
### Automation tests for:
* Login
* View expenses
* View payment requests sent
* View payment requests received
* Add a new expense
* Send a payment request
* Make a payment
* Recall a payment request

    

## How to run the tests
### Stop docker process and start it again by:
    docker ps
    copy id of a process
    docker stop <id>
    docker pull wethinkcode/weshare-qa:2022
    docker run -p 5050:5050 -d wethinkcode/weshare-qa:2022

### To Run Api Test:
    gauge run specs/ApiTestsSpecs/

### To Run Gui Test:
    gauge run specs/GuiTestsSpecs
    

## Thank You!