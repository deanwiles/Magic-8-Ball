rem This batch file will call the Magic 8 Ball RESTful web service and display the JSON or XML response
setlocal
set BaseUrl=https://8ball.delegator.com/magic
set Format=JSON
rem set Format=XML
set Question=Will I win the lottery?
curl "%BaseUrl%/%Format%/%Question%"
