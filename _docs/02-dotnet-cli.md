# dotnet CLI

## Install templates

`dotnet new --install MassTransit.Templates`

``` CLI output
The following template packages will be installed:
   MassTransit.Templates

Success: MassTransit.Templates::1.0.6 installed the following templates:
Template Name                              Short Name      Language  Tags
-----------------------------------------  --------------  --------  ---------------------------
MassTransit Consumer Saga                  mtsaga          [C#]      MassTransit/Saga
MassTransit Docker                         mtdocker        [C#]      MassTransit/Docker
MassTransit Message Consumer               mtconsumer      [C#]      MassTransit/Consumer
MassTransit Routing Slip Activity          mtactivity      [C#]      MassTransit/Activity
MassTransit Routing Slip Execute Activity  mtexecactivity  [C#]      MassTransit/ExecuteActivity
MassTransit State Machine Saga             mtstatemachine  [C#]      MassTransit/StateMachine
MassTransit Worker                         mtworker        [C#]      MassTransit/Worker
```


## Solution/Project creation

dotnet new mtworker -n ServiceWorker
=> Create `ServiceWorker` folder.

dotnet new mtconsumer -n ServiceConsumer
=> Create `Consumers` and `Contracts` folder.
