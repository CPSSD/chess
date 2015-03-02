
// This file has been generated by the GUI designer. Do not modify.
namespace GUI
{
	public partial class SetClockTimeDialog
	{
		private global::Gtk.VBox vbox5;
		
		private global::Gtk.Label label4;
		
		private global::Gtk.HBox hbox2;
		
		private global::Gtk.VBox vbox6;
		
		private global::Gtk.Entry HoursEntry;
		
		private global::Gtk.Label label5;
		
		private global::Gtk.VBox vbox7;
		
		private global::Gtk.Entry MinutesEntry;
		
		private global::Gtk.Label label6;
		
		private global::Gtk.VBox vbox8;
		
		private global::Gtk.Entry SecondsEntry;
		
		private global::Gtk.Label label7;
		
		private global::Gtk.Button buttonCancel;
		
		private global::Gtk.Button buttonOk;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget GUI.SetClockTimeDialog
			this.WidthRequest = 200;
			this.HeightRequest = 125;
			this.Name = "GUI.SetClockTimeDialog";
			this.Title = global::Mono.Unix.Catalog.GetString ("Set Game Time");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			// Internal child GUI.SetClockTimeDialog.VBox
			global::Gtk.VBox w1 = this.VBox;
			w1.Name = "dialog1_VBox";
			w1.BorderWidth = ((uint)(2));
			// Container child dialog1_VBox.Gtk.Box+BoxChild
			this.vbox5 = new global::Gtk.VBox ();
			this.vbox5.Name = "vbox5";
			this.vbox5.Spacing = 6;
			// Container child vbox5.Gtk.Box+BoxChild
			this.label4 = new global::Gtk.Label ();
			this.label4.Name = "label4";
			this.label4.Ypad = 7;
			this.label4.LabelProp = global::Mono.Unix.Catalog.GetString ("Enter a game time below.");
			this.vbox5.Add (this.label4);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox5 [this.label4]));
			w2.Position = 0;
			w2.Expand = false;
			w2.Fill = false;
			// Container child vbox5.Gtk.Box+BoxChild
			this.hbox2 = new global::Gtk.HBox ();
			this.hbox2.Name = "hbox2";
			this.hbox2.Homogeneous = true;
			// Container child hbox2.Gtk.Box+BoxChild
			this.vbox6 = new global::Gtk.VBox ();
			this.vbox6.Name = "vbox6";
			this.vbox6.Spacing = 6;
			// Container child vbox6.Gtk.Box+BoxChild
			this.HoursEntry = new global::Gtk.Entry ();
			this.HoursEntry.WidthRequest = 50;
			this.HoursEntry.CanFocus = true;
			this.HoursEntry.Name = "HoursEntry";
			this.HoursEntry.IsEditable = true;
			this.HoursEntry.MaxLength = 2;
			this.HoursEntry.InvisibleChar = '•';
			this.vbox6.Add (this.HoursEntry);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox6 [this.HoursEntry]));
			w3.Position = 0;
			w3.Expand = false;
			w3.Fill = false;
			// Container child vbox6.Gtk.Box+BoxChild
			this.label5 = new global::Gtk.Label ();
			this.label5.Name = "label5";
			this.label5.LabelProp = global::Mono.Unix.Catalog.GetString ("Hours");
			this.vbox6.Add (this.label5);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox6 [this.label5]));
			w4.Position = 1;
			w4.Expand = false;
			w4.Fill = false;
			this.hbox2.Add (this.vbox6);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.vbox6]));
			w5.Position = 0;
			w5.Expand = false;
			w5.Fill = false;
			// Container child hbox2.Gtk.Box+BoxChild
			this.vbox7 = new global::Gtk.VBox ();
			this.vbox7.Name = "vbox7";
			this.vbox7.Spacing = 6;
			// Container child vbox7.Gtk.Box+BoxChild
			this.MinutesEntry = new global::Gtk.Entry ();
			this.MinutesEntry.WidthRequest = 50;
			this.MinutesEntry.CanFocus = true;
			this.MinutesEntry.Name = "MinutesEntry";
			this.MinutesEntry.IsEditable = true;
			this.MinutesEntry.MaxLength = 2;
			this.MinutesEntry.InvisibleChar = '•';
			this.vbox7.Add (this.MinutesEntry);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vbox7 [this.MinutesEntry]));
			w6.Position = 0;
			w6.Expand = false;
			w6.Fill = false;
			// Container child vbox7.Gtk.Box+BoxChild
			this.label6 = new global::Gtk.Label ();
			this.label6.Name = "label6";
			this.label6.LabelProp = global::Mono.Unix.Catalog.GetString ("Minutes");
			this.vbox7.Add (this.label6);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.vbox7 [this.label6]));
			w7.Position = 1;
			w7.Expand = false;
			w7.Fill = false;
			this.hbox2.Add (this.vbox7);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.vbox7]));
			w8.Position = 1;
			w8.Expand = false;
			w8.Fill = false;
			// Container child hbox2.Gtk.Box+BoxChild
			this.vbox8 = new global::Gtk.VBox ();
			this.vbox8.Name = "vbox8";
			this.vbox8.Spacing = 6;
			// Container child vbox8.Gtk.Box+BoxChild
			this.SecondsEntry = new global::Gtk.Entry ();
			this.SecondsEntry.WidthRequest = 50;
			this.SecondsEntry.CanFocus = true;
			this.SecondsEntry.Name = "SecondsEntry";
			this.SecondsEntry.IsEditable = true;
			this.SecondsEntry.MaxLength = 2;
			this.SecondsEntry.InvisibleChar = '•';
			this.vbox8.Add (this.SecondsEntry);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.vbox8 [this.SecondsEntry]));
			w9.Position = 0;
			w9.Expand = false;
			w9.Fill = false;
			// Container child vbox8.Gtk.Box+BoxChild
			this.label7 = new global::Gtk.Label ();
			this.label7.Name = "label7";
			this.label7.LabelProp = global::Mono.Unix.Catalog.GetString ("Seconds");
			this.vbox8.Add (this.label7);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.vbox8 [this.label7]));
			w10.Position = 1;
			w10.Expand = false;
			w10.Fill = false;
			this.hbox2.Add (this.vbox8);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.vbox8]));
			w11.Position = 2;
			w11.Expand = false;
			w11.Fill = false;
			this.vbox5.Add (this.hbox2);
			global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.vbox5 [this.hbox2]));
			w12.Position = 1;
			w12.Expand = false;
			w12.Fill = false;
			w1.Add (this.vbox5);
			global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(w1 [this.vbox5]));
			w13.Position = 0;
			w13.Expand = false;
			w13.Fill = false;
			// Internal child GUI.SetClockTimeDialog.ActionArea
			global::Gtk.HButtonBox w14 = this.ActionArea;
			w14.Name = "dialog1_ActionArea";
			w14.Spacing = 10;
			w14.BorderWidth = ((uint)(5));
			w14.LayoutStyle = ((global::Gtk.ButtonBoxStyle)(4));
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonCancel = new global::Gtk.Button ();
			this.buttonCancel.CanDefault = true;
			this.buttonCancel.CanFocus = true;
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.UseStock = true;
			this.buttonCancel.UseUnderline = true;
			this.buttonCancel.Label = "gtk-cancel";
			this.AddActionWidget (this.buttonCancel, -6);
			global::Gtk.ButtonBox.ButtonBoxChild w15 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w14 [this.buttonCancel]));
			w15.Expand = false;
			w15.Fill = false;
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonOk = new global::Gtk.Button ();
			this.buttonOk.CanDefault = true;
			this.buttonOk.CanFocus = true;
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.UseStock = true;
			this.buttonOk.UseUnderline = true;
			this.buttonOk.Label = "gtk-ok";
			this.AddActionWidget (this.buttonOk, -5);
			global::Gtk.ButtonBox.ButtonBoxChild w16 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w14 [this.buttonOk]));
			w16.Position = 1;
			w16.Expand = false;
			w16.Fill = false;
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 200;
			this.DefaultHeight = 125;
			this.Show ();
		}
	}
}
