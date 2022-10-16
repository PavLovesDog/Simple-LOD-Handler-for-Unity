# Simple-LOD-Handler-for-Unity
This is a simple LOD system I created for my game which handles GameObject models which have both high-poly &amp; low-poly versions and need to be switched out based on distance to player.

For use a GameObject prefab of the environmental object needs to be created with both low & high poly versions as its children (see image)
The low_poly_model.cs & high_poly_model.cs scripts need to be attached to the respective children of the parent object.
Ensure you set up your correct tags! (an example of this is within the Start() method)

The search sphere from the player can be adjusted at runtime!

If you are having trouble refernecing the low_poly_model.cs & high_poly_model.cs scripts from the LOD_Handler.cs scritpt, try encapsulating all scripts in a namespace.
This is how I usually work with these scripts, but left it out to avoid confusion for other people!

Hope you like it & hope it helps!
