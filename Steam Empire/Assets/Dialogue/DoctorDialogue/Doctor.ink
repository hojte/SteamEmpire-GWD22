{INTRODUCTION: -> SECOND_APPROACH}
{not INTRODUCTION: -> INTRODUCTION}

=== INTRODUCTION ===
Who are you? What do you want?

* [I'm looking for the doctor. That you?] -> FIRST_APPROACH


=== FIRST_APPROACH ===

Yes, that is me. Did you need something? I'm really busy...
    * [I have some questions.] -> QUESTIONS_1
    * [The foreman sent me. I have supplies.] -> FOREMAN_TASK
    
    
=== QUESTIONS_1 ===
I do not have time for this. Unless there is something important/ you're here to help, I'll need you to leave. -> END

    
=== SECOND_APPROACH ===
{FOREMAN_TASK: You're back again? What can I do for you? -> HUB_2}
Didn't I tell you to leave? What do you want now?
    * [The foreman sent me. I have supplies.] -> FOREMAN_TASK 

=== FOREMAN_TASK ===
Thank you. It's not as much as we need, but at least my patients will have something to eat tonight. -> PASS_OUT

=== PASS_OUT ===
-> INFECTION_REVEAL

=== INFECTION_REVEAL ===
    -> HUB_2


=== HUB_2 ===
Did you need anything else?

* [Questions] -> QUESTIONS_2
* [Treatment] -> TREATMENT
* [Help]-> OFFER_HELP
* [I'll be going.] -> LEAVE


=== QUESTIONS_2 ===
What do you want to know?

* [DOCTOR] -> DOCTOR_INFO

* [FOREMAN] -> FOREMAN_INFO

* [DISEASE] -> DISEASE_INFO

* [Most people have to go to the factory to get their food, may I ask why you get it delivered instead?] -> FOOD_INFO

* [That is all for now.] -> HUB_2


=== DOCTOR_INFO ===
    -> QUESTIONS_2

=== FOOD_INFO ===
My position as the district's main doctor has been fairly respected since the beginning of the pandemic. I believe he knows I can help more than most people and that might be why I get additional assisstance on his behalf. -> QUESTIONS_2

=== FOREMAN_INFO ===
-> QUESTIONS_2

=== DISEASE_INFO ===
Not much is known yet besides the fact that it is highly contagious and that it spreads on living things. Actually, some people mention seeing it spread on wood as well, so not even that might be correct
    -> QUESTIONS_2

    
=== TREATMENT ===
TODO: Based on current infection/disease value change respond to can slow spread vs did all that I can for now, come back later
    -> END


=== OFFER_HELP === 
Oh, yeah, definitely, but it is going to be no easy task. I need more tools from outside the distreict, but I can't go myself as guards won't let me out due to the proximity to the diseased... If you are willing to try, I suggest asking the factory foreman for some assisstance.
 * [I'll keep it in mind. See you soon.] -> END

 
=== LEAVE ===
-> END
