CHECKPOINTS - how to catch up if you fall behind
================================================

Each folder holds the project as it looks at the END of that level:

  00-starter           empty scene, where everyone starts
  01-first-objects     Level 1: a box with a material
  02-map               Level 2: an example island
  03-character-moves   Level 3: the character walks and turns
  04-jump-gravity      Level 4: gravity and jumping
  05-coins             Level 5: coins to collect (the finished game)

To catch up:

  1. Double-click the scene in the checkpoint folder to open it.

  2. If the folder has a .txt file, it is the finished script for that level.
     - Open the .txt file, select everything, copy.
     - Open YOUR script with the same name in Assets/Scripts
       (no script yet? Project window: right-click > Create > Scripting >
       MonoBehaviour Script, and give it exactly the same name).
     - Select everything, paste, save.

  3. Attach the script:
     - PlayerController: drag your script onto Player in the Hierarchy.
     - Coin (05 only): open Checkpoints/05-coins/Coin (the blue prefab)
       and drag your Coin script onto it. All ten coins get it at once.

  4. Press Play.

Tip: File > Save As... to save the checkpoint scene under your own name,
so the original stays untouched.
