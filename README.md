# SpaceStation13 Telescience Companion
A calculator for the telescience feature of the game Space Station 13

The goal of this application is to provide a fast interaction between the game and the calculator, attempting to go from in-game coordinates to in-game bearing/elevation/power with the fewest mouse clicks and troubles.

It has been successfully tested at Paradise Station server, I have no idea if it will work on other servers.
If other servers are different, a server selector could be added to the tool.

The calculation code was ported from RageAgainstheCondom's calculator: https://github.com/RageAgainstheCondom/SS13Telecoms-Paradise
Minor changes were made like rounding and the ability to calculate the offsets with variable bearing/elevation/power.

The code is dividen in the main form and the TrajectoryCalculator class, that isolates all calculations from the rest of the code.

Made with Visual Studio Community 2017
