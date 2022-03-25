-> AMBUSH

TODO: Ideas: - Something about toll?
TODO: Dumb it down

=== AMBUSH ===
{not WHO: Hey, hold up. What you got there?}
{WHO: Now. Tell me what you have there before I lose my patience.}
* [Who are you?] -> WHO
* [It's nothing.] -> NOTHING
* [A food delivery for the FOREMAN.] -> FOOD
* [Get out of my way.] -> GET_LOST


=== WHO ===
TODO: Add who they are or deflect question
    -> AMBUSH


=== NOTHING ===
Do you think we're stupid? I know you're not from the district. And they don't let anybody in unless there's a good reason. 

* {not WHO} [Who are you, anyway?] -> WHO
* [A food delivery for the FOREMAN.] -> FOOD
* [Get out of my way.] -> GET_LOST


=== FOOD ===
{NOTHING or GET_LOST: You thought you could hide that from us? We've been starving ever since the rest of the city abandoned us. I smelled the food the minute you entered the district. Now leave the SHIPMENT and get lost.}

{not (NOTHING or GET_LOST): 
    Really? A food delivery? Seems to be our lucky day, boys. You see, there isn't enough food to go around. And we've been starving ever since the FOREMAN decreased rations. So, since you're working for him... Why don't you help us out? By handing over that SHIPMENT.
    }
    * [Maybe we can make a deal?] -> DEAL
    * [Sorry, but I have to deliver the whole SHIPMENT.] -> CANT_HELP
    * [Get out of my way.] -> GET_LOST


=== GET_LOST ===
{CANT_HELP: I don't see any protection. <>}
There's three of us, you're alone and not exactly the fighting type. <>
TODO: INSULT HERE
TODO: More?

* [I'm sorry. I'm not looking for trouble] -> APOLOGIZE
* [Wait! What do you think happens when the FOREMAN hears that you stopped me?] -> ARGUE


=== DEAL ===
You want us to pay? For something we can just take for free? The balls on this one.
TODO: AMIRITE GUYS.
Here's a deal for you. You hand over the SHIPMENT and maybe... We don't kill you.

* [Wait! What do you think happens when the FOREMAN finds out that you're stealing his SHIPMENT?] -> ARGUE


=== CANT_HELP ===
TODO: SO... THIS IS JUST FULLY MISSING
This isn't a negotiation. I'm telling you to do something and if you don't then we'll force you.

* {not GET_LOST} [Just get out of my way. I'm protected.] -> GET_LOST
* [I have an agreement with the FOREMAN.] -> ARGUE


=== APOLOGIZE ===
Maybe choose your words carefully next time. Now hand over the SHIPMENT and maybe we'll let you live.
* [Wait! What do you think happens when the FOREMAN finds out that you're stealing his SHIPMENT?] -> ARGUE


=== ARGUE ===
{DEAL: Are you for real? A minute ago you wanted to sell me his food and now you want me to worry about him? Besides... <>}
{(GET_LOST or APOLOGIZE): So that's who you're working for? Should've guessed. Doesn't matter now. <>}
{CANT_HELP: So you're another of those UPPER CITY FOLKS profiting of the disease... You think mentioning the FOREMAN scares us? <>}
He doesn't care about some OUTSIDER. And it's not like he's not gonna find out that it was us. -> KNOCKOUT


=== KNOCKOUT ===
GET HIM/WHISTLES THEN LOSS OF CONSCIOUSNESS
-> END



