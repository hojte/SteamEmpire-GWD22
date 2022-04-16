INCLUDE globals.ink

{infection_reveal: You're back again? What can I do for you? -> HUB_2}
-> INFECTION_REVEAL_I

=== INFECTION_REVEAL_I ===
~infection_reveal = true
TODO: Fade from black after/at easy now?
You're awake. Easy now. I examined you, while you were passed out... 
You're infected. I'm sorry. 
    *[What? How... That's impossible.] -> INFECTION_REVEAL_II
TODO: make connection that hoodlums infected PC? Clear enough?
    
=== INFECTION_REVEAL_II ===
From the progression I'd assume you caught the disease within the last 12 hours ago. I did what I could to treat it, but... All I can do is slow the spread.
* [...] -> HUB_2
TODO: This transition might need to be smoother

=== HUB_2 ===
Can I do anything else for you?

* [I have some questions.] -> QUESTIONS_2
* [Could you look at my infection again?] -> TREATMENT
TODO: maybe rephrase this
* [Do you need help finding a cure?]-> OFFER_HELP 
* [I'll be going.] -> END


=== QUESTIONS_2 ===
What do you want to know?

* [Not many physicians around here...] -> DOCTOR_INFO

TODO: Unlocks if talked about doctor and saw the workshop * [WORKSHOP] -> WORKSHOP_INFO

* [What happened here since the outbreak?] -> FOREMAN_INFO

* [What do you know about the disease?] -> DISEASE_INFO

* [Why does the foreman supply you?] -> SUPPLIES_INFO

* [That is all for now.] -> HUB_2


=== DOCTOR_INFO ===
That's right. Physicians used to come here once or twice a week. But since the emperor closed the district they won't let them in anymore. I was only allowed in, because I used to have a workshop here. This district isn't as restrictive on research as the other ones. But I had to keep it closed since the outbreak. There are more pressing matters.
    -> QUESTIONS_2
    
=== WORKSHOP_INFO ===
-> QUESTIONS_2

=== SUPPLIES_INFO ===
Why wouldn't he? I'm the only doctor in the entire district. And the foreman doesn't want all his workers to die from the disease. So I take care of his people and he makes sure I have everything I need and can work in peace. Besides, it's in his interest that we find a cure and I'm the only one working on that. -> QUESTIONS_2

=== FOREMAN_INFO ===
TODO: Add something about 
We've been on our own, since the emperor locked down the district. The magistrate fled and the city watch isn't allowed to enter anymore. So now the foreman is in charge of security around here. He also rations the few supply shipments we get. He's done a fairly good job at keeping the district from rioting. That's all I can tell you.
-> QUESTIONS_2

=== DISEASE_INFO ===
TODO: Should be sort of dodgy on this part, knows exactly where the disease came from, but does not want to talk about it, maybe sense of pride for figuring out some of it, but also see previous point. Only one who can figure this out, because has all the information
Let's see... It's highly contagious, but fairly slow. Infects anything organic.  Wood, plants, animals... Humans. Haven't seen it on stone. That's probably why it hasn't spread to the upper districts. The people here were barely allowed to leave before, let alone now. And... Sorry to say, but I haven't found a cure. It's a death sentence. At least for now.

    -> QUESTIONS_2

    
=== TREATMENT ===
I still don't have a cure, yet. All I can do is slow the spread.
TODO: Based on current infection/disease value change respond to can slow spread vs did all that I can do for now, come back later
{disease < 50: There isn't anything I can do for you at the moment. Come back later.}
{disease >= 50: Lie down and I'll see what I can do.}
    -> END


=== OFFER_HELP === 
Not at the moment. I have patients to treat and you are already infected. But come back later, I could use some assisstance in my research. 
-> HUB_2