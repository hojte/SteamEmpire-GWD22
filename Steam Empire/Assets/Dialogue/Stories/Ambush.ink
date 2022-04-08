-> AMBUSH

TODO: Dumb it down
TODO: Shipment in cart, cart stuck

=== AMBUSH ===
{not WHO: Wait a minute. I don't think I've seen you around here before. What dare you doing here?}
{WHO: Now. Tell me what's on the cart before I lose my patience.}
//* [Who are you?] -> WHO
* [Just passing by.] -> NOTHING
* [Bringing supplies for the foreman.] -> FOOD
* [Get out of my way.] -> GET_LOST


=== WHO ===
TODO: Add who they are or deflect question
    -> AMBUSH


=== NOTHING ===
Do you think we're stupid? We've been watching you since you entered the the district with that cart of yours. Why are you here? 

//* {not WHO} [Who are you, anyway?] -> WHO
* [I have a batch of supplies for the foreman.] -> FOOD
* [Get out of my way.] -> GET_LOST


=== FOOD ===
{NOTHING or GET_LOST: Thought you could hide that from us, didn't you? We've been starving ever since the rest of the city abandoned us. I suggest you leave the cart and go back to your cozy home. We don't want you here.}

{not (NOTHING or GET_LOST): 
    Really? Supplies? I bet that means food. Seems to be our lucky day, boys. You see, we've been starving ever since the foreman decreased rations. So, since you're working for him... Why don't you help us out? Leave the cart. I promise we'll share.
    }
    * [Maybe we can make a deal?] -> DEAL
    * [I can't. I have to deliver everything on that cart.] -> CANT_HELP
    * [Get out of my way.] -> GET_LOST


=== GET_LOST ===
{CANT_HELP: I don't see any protection. <>}
There's three of us, you're alone and not exactly the fighting type. <>

* [I'm sorry. I wasn't looking for trouble.] -> APOLOGIZE
* [Wait! What do you think the foreman is going to do to you when he hears that you stopped me?] -> ARGUE


=== DEAL ===
You want us to pay? For something we can just take for free?
Here's a deal for you. You leave those supplies to us and in return you get to go home.

* [Wait!  What do you think the foreman is going to do to you when he finds out that you're stealing his supplies?] -> ARGUE


=== CANT_HELP ===
This isn't a negotiation. I'm telling you to do something and if you don't then we'll force you.

* {not GET_LOST} [Just get out of my way. I have protection.] -> GET_LOST
* [I have an agreement with the foreman.] -> ARGUE


=== APOLOGIZE ===
Maybe choose your words carefully next time. Now hand over your shipment and maybe we'll let you live.
* [Wait! What do you think happens when the foreman finds out that you're stealing his SHIPMENT?] -> ARGUE


=== ARGUE ===
TODO: too modern?
{DEAL: Are you for real? A minute ago you wanted to sell me his food and now you want me to worry about him? Besides... <>}
{(GET_LOST or APOLOGIZE): So that's who you're working for? Should've guessed. Doesn't matter now. <>}
{CANT_HELP: So it wasn't enough for the upper city to abandon us. You have to profit of the disease... But the foreman won't help you now. <>}
He doesn't care about some outsider. And it's not like he's gonna find out that it was us. 
-> END


