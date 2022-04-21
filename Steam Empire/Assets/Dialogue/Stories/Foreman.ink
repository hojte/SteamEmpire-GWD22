INCLUDE globals.ink

You took your time. You were supposed to arrive hours ago.

* [I'm sorry. The road was blocked. I left the cart at the gate...] -> EXPLANATION

 === EXPLANATION ===
You what?! Where are my supplies? Is the cart still at the gate?

*[They were waiting for me. They knocked me out and took everything.] -> AMBUSHERS

=== AMBUSHERS ===
What?! Who ambushed you? Did you get a look at them?

* [I don't know. They wore masks.] -> ANGERY

=== ANGERY ===
Useless!

* [I need you help. They stole my pass, too. The guard at the gate won't let me leave.] -> HELP_PLS
* [I can't get your shipment back. But I can get you a discount on the next one.] -> DISCOUNT

=== HELP_PLS ===

=== DISCOUNT ===
A discount? How awfully nice of you. You lost my shipment, but I have a discount next time. We're running out of food. We needed those supplies. Now I'll have to cut rations again. The situation is tense enough as it is. 

I'll take your offer. But you better put that shipment together quickly. And I'm not paying you for the one you botched. 

* [I'll do what I can. But I need your help getting out. They took my pass and the guard won't let me leave.] -> ARGUMENT


=== ARGUMENT ===
Right. Of course. Maybe I should just look for a new... partner. Someone more reliable. Someone who ensure the safety of my investments.

* [How many people are even willing to make these deliveries? You need me.] -> OFFER

=== OFFER ===
Maybe. It would certainly take time I don't have. But getting you out of the district will take time too. And it's very expensive. You'll owe me.

* [Alright. Just help me get out.] -> PREPARATIONS

=== PREPARATIONS ===
Good. I'll take the necessary preparations. While your stuck here you can start paying off your debt. Do some work for me. -> DOCTOR_TASK


=== DOCTOR_TASK ===
There's a physician. She's set up down by the NAME OF THE PLACE. You can't miss her. She turned the entire area into a makeshift hospital. 

I need you to bring her this satchel of supplies. Don't lose them again or you won't be leaving this district after all. Got it?

Now get going. I have work to do.

* [I have questions.] -> QUESTIONS
* [I'll get going.] -> END



=== QUESTIONS ===
Make it quick.

* [I better get going.]-> END