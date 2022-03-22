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
    * [Maybe I can spare a little bit] -> HELP
    * [Sorry, but I can't] -> CANT_HELP
    * [Get out of my way] -> GET_LOST
}

=== GET_LOST ===
Where do you think you are? This is our turf.

* [I'm not looking for trouble] -> APOLOGIZE

* [What do you think is going to happen when BOSS hears that you stopped me?] -> ARGUE
Get him -> KNOCKOUT

=== HELP ===
We want all of it
* [I can't do that. The SHIPMENT is for BOSS]
* [ w]

=== CANT_HELP ===
Why? You another of those UPPER CITY FOLKS profiting of the disease?
{not GET_LOST: * [Just get out of my way] -> GET_LOST}
* []

-> KNOCKOUT

=== TAKE_FOOD ===
{CANT_HELP: We're already starving. But with this we'll be alright for a while.} -> KNOCKOUT

=== APOLOGIZE ===
Maybe choose your words carefully next time. Now hand over the SHIPMENT and maybe we'll let you live. -> KNOCKOUT

=== ARGUE ===
He doesn't care about some OUTSIDER. Besides he's not gonna find out. -> KNOCKOUT

=== KNOCKOUT ===
-> END



