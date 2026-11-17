Animated pixel art by Frakassets - https://frakassets.itch.io/

The chests open and close; the mimic breathes and bites; the coin pouch and
the key turn on the spot (24 frames). Every frame is a square of the sheet's
size (16 x 16, 32 x 32, 48 x 48 or 64 x 64 pixels), transparent PNG. Play
them at 12 frames per second.

File names: <item>_<size>_<angle>_<outline>_<shade>.png
  size     16px, 32px, 48px or 64px
  angle    scroller (facing the camera, seen a little from above) or
           top-down (seen from above at 45 degrees)
  outline  outline (dark outer border) or no-outline
  shade    lit, or unlit (flat colours: light them yourself)
  <item>_<size>_<angle>_normal.png is the normal map, for 2D lights
  (x right, y up, z towards the camera).

Chest sheets: one row per animation and side, one column per frame.
  top-down   8 rows: Close South, East, North, West, then Open South, East,
             North, West (South = the front, facing you)
  scroller   2 rows: Close, then Open (the front)
  Open is 10 frames (the lid rattles, flies open and settles), Close 6 (it
  slams). Open's last frame is the open chest, Close's last the closed one:
  hold either as a still.
  Mimic: Bite (6 frames, loop) and Idle (12 frames, loop: it breathes, its
  lid lifting on its teeth), in the same order of sides.
  Rows are as wide as the longest animation; the shorter ones end early.
  <item>_<size>_<angle>.json gives every frame's place, animation, side and
  pivot (Aseprite's JSON hash, with frame tags), for every variant of that
  size and angle.
Coin pouch and key sheets: one row of 24 frames, a full turn, looping.

How to use
----------
1. Unzip. Each item has its own folder.
2. Pick a sheet (see the file names above).
3. Import:
   Godot 4    Default texture filter Nearest. AnimatedSprite2D > SpriteFrames >
              Add frames from sprite sheet: Horizontal = the columns, Vertical =
              the rows, then pick the cells of one row per animation; 12 FPS.
              Open and Close do not loop; Bite, Idle and the turns do.
   Unity      Texture Type Sprite (2D and UI), Sprite Mode Multiple, Filter
              Point, Compression None, Pixels Per Unit = the sheet's size.
              Sprite Editor > Slice > Grid By Cell Size (16, 32, 48 or 64).
   GameMaker  Create Sprite > Import Strip Image, one row at a time (frames:
              10 for Open, 6 for Close), size = the sheet's size; 12 frames
              per second.
   Aseprite   Open the PNG with its .json beside it, or File > Import >
              Import Sprite Sheet, By Rows, width and height = the sheet's size.
   Normal maps line up frame for frame with the sheets (Godot CanvasTexture,
   Unity Secondary Textures > _NormalMap).

Made with Pixor, the tool that turns 3D models into animated pixel-art
sprite sheets: every side, frame by frame, the same pixels every time.
Pay once, no AI-generated pixels, offline. https://pixor.art/

If you use these, a rating or a comment on the itch page helps a lot. Thank you!
