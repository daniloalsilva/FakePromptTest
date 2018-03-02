# FakePromptTest

FakePromptTest is an executable who sleeps through a specified amount of time.
It can be used to test plugin behaviours in monitoring systems, such as Nagios and CheckMK.

## FakePromptTest usage:

    FakePromptTest.exe {int} Param2 Param3

The first param will be considered as seconds to finish execution (to sleep)
Other used params don't really matter, but will be printed in console

if the first param is not a integer, the program will not sleep

### Execution/Result example:

    .\FakePromptTest.exe 10 param2 600

    3 params used.
    params: 10, param2, 600
    Starting Threading.Sleep
    . . . . . . . . . .
    Threading.Sleep Finished. Waiting Time: 10,0075s
