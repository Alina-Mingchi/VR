//using System;

//public abstract class Switch : InteractiveItem {
//	public override void interacted_with ( MainPlayerController player ) { self_toggled_by( player ); }

//	// Store the reference to the function to call when an interaction with the player occurs
//	protected Action on_toggled_callback;

//	// Allow external objects (such as a controller) to tell which function to call when an interaction with the player occurs
//	public void on_toggled ( Action callback ) { on_toggled_callback = callback; }

//	// Once the switch is toggled, call the stored function if it is defined
//	public virtual void self_toggled_by ( MainPlayerController player ) { if ( on_toggled_callback != null ) on_toggled_callback(); }
//}


using System;

public abstract class Switch : InteractiveItemObj
{
    public override void interacted_with_obj(ObjectAnchor trigger_obj_anchor) { self_toggled_by(trigger_obj_anchor); }

    // Store the reference to the function to call when an interaction with the player occurs
    protected Action on_toggled_callback;

    // Allow external objects (such as a controller) to tell which function to call when an interaction with the player occurs
    public void on_toggled(Action callback) { on_toggled_callback = callback; }

    // Once the switch is toggled, call the stored function if it is defined
    public virtual void self_toggled_by(ObjectAnchor trigger_obj_anchor) { if (on_toggled_callback != null) on_toggled_callback(); }
}