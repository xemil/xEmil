﻿using xEmilForms.Core;

namespace xEmilForms.Model
{
	public class ComicBookCharacter : ObservableObject
	{
		private string _name;

		public string Name
		{
			get { return _name; }
			set
			{
				_name = value;
				OnPropertyChanged();
			}
		}

		private string _link;

		public string Link
		{
			get { return _link; }
			set
			{
				_link = value;
				OnPropertyChanged();
			}
		}

		public override string ToString()
		{
			return Name;
		}
	}
}