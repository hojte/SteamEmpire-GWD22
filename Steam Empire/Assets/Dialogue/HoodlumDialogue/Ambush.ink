-> AMBUSH

=== AMBUSH ===
{not WHO: What you got there?}
{WHO: Now tell me}
* [Who are you?] -> WHO
* [Nothing] -> NOTHING
* [Food] -> FOOD
* [Get out of my way] -> GET_LOST

=== WHO ===
TODO: To be added 
    -> AMBUSH

=== NOTHING ===
Doesn't look like nothing to me.

* [Who are you, anyway?] -> WHO
* [Food] -> FOOD
* [Get out of my way] -> GET_LOST

=== FOOD ===
{NOTHING or GET_LOST: Thought you could hide that from us? Hand over}

{NOTHING or GET_LOST: 
    Really? We are starving. Why don't you help us out
    * [Sorry, but I can't] -> CANT_HELP
    * [Get out of my way] -> GET_LOST
}

=== GET_LOST ===
Where do you think you are? This is our turf.
Get him -> KNOCKOUT

=== CANT_HELP ===
-> KNOCKOUT


=== KNOCKOUT ===
-> END



