TODO: Add foreman dialogue condition

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
TODO: What is the status of medical science here? What is needed to combat the disease?
{QUESTIONS_1: Why didn't you start with that? <>}
Just put them down anywhere. Tell the FOREMAN that it's appreciated. But if he really wants this to get better we'll need more/to combat this/fix the district/help the district. MAYBE list WHAT IS NEEDED Way more. We need... -> PASS_OUT

=== PASS_OUT ===
Are you feeling okay?
TODO: Pass out here
-> INFECTION_REVEAL_I

=== INFECTION_REVEAL_I ===
Oh, YOU'RE BACK WITH US/AWAKE. TAKE IT EASY. I examined you, while you were passed out... 
You're infected. I'm sorry. 
    *[What? How... That's impossible.] -> INFECTION_REVEAL_II
TODO: make connection that hoodlums infected PC?
    
=== INFECTION_REVEAL_II ===
From the progression I'd assume you caught the disease X hours ago. I did what I could to treat it, but... All I can do is slow the spread.
* [...] -> HUB_2

=== HUB_2 ===
Can I do anything else for you?

* [I have some questions.] -> QUESTIONS_2
* [Anything you can do to treat me?] -> TREATMENT
* [Is there anything else I can do for you?]-> OFFER_HELP
* [I'll be going.] -> LEAVE


=== QUESTIONS_2 ===
What do you want to know?

* [DOCTOR] -> DOCTOR_INFO

* [FOREMAN] -> FOREMAN_INFO

* [DISEASE] -> DISEASE_INFO

* [Most people have to go to the factory to get their food, may I ask why you get it delivered instead?] -> FOOD_INFO

* [That is all for now.] -> HUB_2


=== DOCTOR_INFO ===
TODO: Not from around here, used to have my workshop here; bunch of things you cannot do/aren't allowed to do in the other districts; MAYBE WORKSHOP CAN BE FOUND AND LOOKS LIKE CENTER OF DISEASE
    -> QUESTIONS_2

=== FOOD_INFO ===
My position as the district's main doctor has been fairly respected since the beginning of the pandemic. I believe he knows I can help more than most people and that might be why I get additional assisstance on his behalf. -> QUESTIONS_2

=== FOREMAN_INFO ===
-> QUESTIONS_2

=== DISEASE_INFO ===
TODO: Should be sort of dodgy on this part, knows exactly where the disease came from, but does not want to talk about it, maybe sense of pride for figuring out some of it, but also see previous point. Only one who can figure this out, because has all the information
Let's see... It's highly contagious. Spreads on anything ORGANIC.  WOOD, PLANTS, ANIMALS... HUMANS. Haven't seen it on stone. That's probably why it hasn't spread to the UPPER/OTHER districts. THEY BARELY LET PEOPLE LEAVE BEFORE, LET ALONE NOW. And... Sorry to say, but I haven't found a cure. It's a death sentence. At least for now.

    -> QUESTIONS_2

    
=== TREATMENT ===
I haven't found a cure, yet. All I can do is slow the spread.
TODO: Based on current infection/disease value change respond to can slow spread vs did all that I can do for now, come back later
There isn't anything I can do for you at the moment. Come back later.
Lie down and I'll see what I can do.
    -> END


=== OFFER_HELP === 
Oh, yeah, definitely, but it is going to be no easy task. I need more tools from outside the distreict, but I can't go myself as guards won't let me out due to the proximity to the diseased... If you are willing to try, I suggest asking the factory foreman for some assisstance.
 * [I'll keep it in mind. See you soon.] -> END

 
=== LEAVE ===
-> END
