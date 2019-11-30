Running the tests

Project is using page object model.
Run test case "VerifyIncorrectNameErrorMsg.cs" with test data saved in \Utils\XMLFile1.xml

Change browser by using startBrowser():

Driver.initChromeBrowser(); - Chrome
Driver.initIEBrowser() - IE
Driver.initFFBrowser() - FireFox

If file location can't be found.. there are two places to look at:
Test Data is at \Utils\XMLFile1.xml in script "Utilities.cs"
Drivers are at \Utils\chromedriver.exe in script "Driver.cs"