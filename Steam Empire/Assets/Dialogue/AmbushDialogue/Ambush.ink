-> AMBUSH

=== AMBUSH ===
{not WHO: What you got there?}
{WHO: Now tell me}
* [Who are you?] -> WHO
* [It's nothing] -> NOTHING
* [A food delivery for BOSS] -> FOOD
* [Get out of my way] -> GET_LOST

=== WHO ===
TODO: To be added 
    -> AMBUSH

=== NOTHING ===
Doesn't look like nothing to me.

* [Who are you, anyway?] -> WHO
* [A food delivery for BOSS] -> FOOD
* [Get out of my way] -> GET_LOST

=== FOOD ===
{NOTHING or GET_LOST: Thought you could hide that from us? Hand over}

{not (NOTHING or GET_LOST): 
    Really? A food delivery? Seems to be our lucky day, boys. You see, there isn't enough food to go around. And we've been starving ever since BOSS decreased rations. So, since you're working for him... Why don't you help us out? By handing over that SHIPMENT.
    }
    * [Maybe we can make a deal?] -> HELP
    * [Sorry, but I can't] -> CANT_HELP
    * [Get out of my way] -> GET_LOST

=== GET_LOST ===
Where do you think you are? This is our turf.

* [I'm not looking for trouble] -> APOLOGIZE

* [What do you think is going to happen when BOSS hears that you stopped me?] -> ARGUE
Get him -> KNOCKOUT

=== HELP ===
That's great. I think we'll take all of it. Get him
* [Wait, you can't. The shipment is for BOSS. What do you think happens when he finds out?] -> ARGUE


=== CANT_HELP ===
Why? You another of those UPPER CITY FOLKS profiting of the disease?
{not GET_LOST: * [Just get out of my way] -> GET_LOST}
* [I have an agreement with BOSS. ] -> ARGUE

-> KNOCKOUT

=== TAKE_FOOD ===
{CANT_HELP: We're already starving. But with this we'll be alright for a while.} -> KNOCKOUT

=== APOLOGIZE ===
Maybe choose your words carefully next time. Now hand over the SHIPMENT and maybe we'll let you live. -> KNOCKOUT

=== ARGUE ===
He doesn't care about some OUTSIDER. Besides he's not gonna find out. -> KNOCKOUT
TODO: Add something about reasoning how they think they'll get away with this.

=== KNOCKOUT ===
-> END



