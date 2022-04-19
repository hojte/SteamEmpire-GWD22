INCLUDE globals.ink

{ambushed && GUARD: I told you to get lost. -> END}

-> GATE

=== GATE ===
+ {not ambushed} [\[Knock {KNOCKING: again.| at the gate.}\]] -> KNOCKING 
TODO: Rename to something more obvious
+ {ambushed} [\[Knock.\]] -> GUARD
+ [\[Leave.\]] -> END

=== KNOCKING ===
(...)
-> GATE

=== GUARD ===
District pass?
* [Of course. One moment.] -> GUARD_II
    



=== GUARD_II ===
(...)
* [I can't find it. It must have been stolen.] -> GUARD_III

=== GUARD_III ===
No pass. No passage.
* [But you let me through earlier. You must remember me!]
    I've been here for a few hours and I haven't seen you before. Now get lost. -> END
