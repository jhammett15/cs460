# Homework 2

[Repository](https://github.com/jhammett15/jhammett15.github.io) 

The task for Homework 3 was to translate a program from Java to C#. This program was a binary number generator. It took in an integer greater than one in decimal and output a list of binary numbers from one up to that number. We were to do this in Microsoft Visual Studio. I had used neither this nor C# before.

## Download Visual Studio

You can download Visual Studio [here](https://visualstudio.microsoft.com/). It was a bit intimidating at first because there were so many buttons. Figuring out which kind of project I needed to create in the first place was probably the most difficult part. Once that was done it was fairly easy, Visual Studio autogenerates the basic starting code that you need. 

## Translating the Node class

The Node class was very straightforward to translate, the syntax for C# and Java matched up exactly, the only differences in the files is the using statements at the top of the C# file, and the naming conventions. In C#, field names are capitalized whereas in Java they aren't. 

## Translating the QueueInterface class

Again, the differences between Java and C# in the QueueInterface class were minimal. Convention says the method names, so I capitalized Push, Pop and IsEmpty. The other difference was the throws clause. C# doesn't have checked exceptions like Java does, all of its exception handling is done in try/catch blocks. Therefore the throws QueueUnderflowException clause in the Pop method was omitted.

## Translating the QueueUnderflowException class

This class was a little more complicated to translate. C# has no equivalent to Java's RuntimeException class, which the QueueUnderflowException java class extends. Furthermore, the java class calls to the constructors of its superclass. This meant that in order to find out what was happening, I had to look up the documentation for RuntimeException in order to simulate it. The source code for Java's RuntimeException class can be found [here](http://developer.classpath.org/doc/java/lang/RuntimeException-source.html). What I saw there was that the default constructor was empty. Thus for my C# file I left the default constructor empty. This way it will return null. The constructor with the String parameter was a little trickier.  The RuntimeException version of this method called its super class's constructor (Exception), which in turn called its super class's constructor (Throwable). I found the source code I needed [here](http://developer.classpath.org/doc/java/lang/Throwable-source.html). What I found was that it called the fillInStackTrace() method, which prints out the stack trace up to the point of the exception, and prints out the message that was passed in to the console. Therefore, in my QueueUnderflowException C# file, I used a Console.WriteLine to print the message to the screen, then used another Console.WriteLine to print the stack trace, which I found using Environment.StackTrace.

## Translating the LinkedQueue class

