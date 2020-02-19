# Default Template for SDG .NET Course

This is the default template for a simple .NET Core console app. This template has:

- github integration

## To push to github

To create and push your current code to github, use the task `create-github`.

How?

1. Open your command pallette by using (Mac) `shift + cmd + p` or (Windows) `shift + ctrl + p`
2. Search and Select `Tasks: Run Task`
3. Select `create-github` from the dropdown

This will create a new github repo, locally and up on github and also push your current code.

## To turn in your assignment:

after you have created a github repo, completed your project and pushed your code, follow these instructions: https://suncoast.io/handbook/tools/assignment-turn-in/

## PROTIP:

xCreate a new console application that will store the list of dinosaurs they have in the park

xYou will be creating a class for your dinosaurs

xa Dinosaur has the following properties

xName
xDietType - This will be carnivore or herbivore
xDateAcquired - This will be defaulted when the dinosaur is created
xWeight - In pounds, how heavy the dinosaur is
xEnclosureNumber - the Pen that the dinosaur is currently in, thing should be a number
xYour dinosaurs will be stored in a List<Dinosaur>.

xWhen the console application runs, it should let the user choose one of the following actions:

View All the current dinosaurs
this command will show the all the dinosaurs in a the list, ordered by DateAcquired
x Add a new dinosaur
xThis command will let the user type in the information for a dinosaur and add it to the list
xRemove a dinosaur
xThis will delete a dinosaur by name
xTransfer
xAdd the ability to update a dinosaur to a new enclosure
View The 3 heaviest dinosaurs
Diet summary
This will the total number of each type of diet
quit the program
this will stop the program

Epic Mode
Eventually we will be using a MVC application structure. To prepare for this, refactor your code to have all your business logic in separate class, called ParkService and all your console interaction in the main class.

Your data is currently stored in a list. This list is lost every time the program restarts. On Monday, we starting to explore something called SQL. Add a database. Convert your code to use Ef Core to store your data in a database.
