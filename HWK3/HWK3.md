# Homework 3

[Repository](https://github.com/jhammett15/jhammett15.github.io) 

The task for Homework 3 was to translate a program from Java to C#. This program was a binary number generator. It took in an integer greater than one in decimal and output a list of binary numbers from one up to that number. We were to do this in Microsoft Visual Studio. I had used neither this nor C# before.

## Download Visual Studio

You can download Visual Studio [here](https://visualstudio.microsoft.com/). It was a bit intimidating at first because there were so many buttons. Figuring out which kind of project I needed to create in the first place was probably the most difficult part. Once that was done it was fairly easy, Visual Studio autogenerates the basic starting code that you need. 

## Translating the Node class

The Node class was very straightforward to translate, the syntax for C# and Java matched up exactly, the only differences in the files is the using statements at the top of the C# file, and the naming conventions. In C#, field names are capitalized whereas in Java they aren't. 

## Translating the QueueInterface class

Again, the differences between Java and C# in the QueueInterface class were minimal. Convention says the method names, so I capitalized Push, Pop and IsEmpty. The other difference was the throws clause. C# doesn't have checked exceptions like Java does, all of its exception handling is done in try/catch blocks. Therefore the throws QueueUnderflowException clause in the Pop method was omitted.

## Translating the QueueUnderflowException class

This class was a little more complicated to translate. C# has no equivalent to Java's RuntimeException class, which the QueueUnderflowException java class extends. Instead, the C# file needed to inherit from C#'s SystemExeption class, which syntactically was done with a colon. Furthermore, the java class calls to the constructors of its superclass. This meant that in order to find out what was happening, I had to look up the documentation for RuntimeException in order to simulate it. The source code for Java's RuntimeException class can be found [here](http://developer.classpath.org/doc/java/lang/RuntimeException-source.html). What I saw there was that the default constructor was empty. Thus for my C# file I left the default constructor empty. This way it will return null. The constructor with the String parameter was a little trickier.  The RuntimeException version of this method called its super class's constructor (Exception), which in turn called its super class's constructor (Throwable). I found the source code I needed [here](http://developer.classpath.org/doc/java/lang/Throwable-source.html). What I found was that it called the fillInStackTrace() method, which prints out the stack trace up to the point of the exception, and prints out the message that was passed in to the console. Therefore, in my QueueUnderflowException C# file, I used a Console.WriteLine to print the message to the screen, then used another Console.WriteLine to print the stack trace, which I found using Environment.StackTrace.

## Translating the LinkedQueue class

The differences between the Java LinkedQueue file and the one written in C# were all syntactical. Naming conventions once again stated that fiend and method names were to be capitalized. Implementing an interface in C# is done as a colon followed by the name of the interface rather than an implements clause. C#'s equivalent to Java's NullPointerException class is called NullReferenceException.  The only other syntactical difference was that C# does not have an else if clause. Therefore, you just put another if/else statement inside the else clause of the first. I did run into one issue with this class in the Pop method when I initially tried to set tmp to null. It gave an error saying that it could not convert a null type to parameter T because it could be a non-nullable value type. How I ended up solving this was I did not assign tmp an initial value.

## Translating the Main class

Again, these two classes were very similar, they just had minor differences in method and class names. Convention in C# says that the string class should not be capitalized. C#'s equivalent to Java's add method in the LinkedList class was AddLast. getLast() became just Last(). Java's Integer.parseInt() method in the Main method was equivalent to C#'s int.Parse(). The method in C# to return the length of a string is called without parentheses. C# has a dedicated foreach loop rather than just extending the syntax of the for loop. The only other different was in the NumberFormatEXception class in Java behaved slightly differently to C#'s FormatException class I believe. In the Java file when the exception was thrown, it printed out a message to the console. In my C# file, it just printed out the stack trace. I never quite got this figured out.