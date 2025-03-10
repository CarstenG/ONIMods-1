﻿/*
 * Copyright 2021 Peter Han
 * Permission is hereby granted, free of charge, to any person obtaining a copy of this software
 * and associated documentation files (the "Software"), to deal in the Software without
 * restriction, including without limitation the rights to use, copy, modify, merge, publish,
 * distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the
 * Software is furnished to do so, subject to the following conditions:
 *
 * The above copyright notice and this permission notice shall be included in all copies or
 * substantial portions of the Software.
 *
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING
 * BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
 * NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM,
 * DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
 * FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
 */

namespace PeterHan.ModUpdateDate {
	/// <summary>
	/// Strings used in Mod Updater.
	/// </summary>
	public static class ModUpdateDateStrings {
		public const int MAX_LINES = 16;

		public static class UI {
			public static class MODUPDATER {
				// Confirmation of update
				public static LocString CONFIRM_UPDATE = "Continuing will reinstall the latest version of:\n" +
					"{0}from the Workshop.\n<color=#FFCC00>A best effort will be made to preserve mod options.</color>\n\n" +
					"Check again after updating and enable the mod if necessary.";
				public static LocString CONFIRM_LINE = "<b>{0}</b>\n";
				public static LocString CONFIRM_MORE = "<i>(and {0:D} more...)</i>\n";
				public static LocString CONFIRM_CANCEL = "CANCEL";
				public static LocString CONFIRM_OK = "FORCE UPDATE";

				// Local update date
				public static LocString LOCAL_UPDATE = "<b>Local Updated:</b> {0:f}";

				// Main menu update
				public static LocString MAINMENU_UPDATE = "\n\n<color=#FFCC00>{0:D} mods may be out of date</color>";
				public static LocString MAINMENU_UPDATE_1 = "\n\n<color=#FFCC00>1 mod may be out of date</color>";

				public static LocString OPTION_MAINMENU = "Show Updates in Main Menu";
				
				// Mod update status
				public static LocString MOD_UPDATED = "This mod appears to be up to date.";
				public static LocString MOD_UPDATED_BYUS = "This mod was locally updated by Mod Updater.";
				public static LocString MOD_OUTDATED = "This mod appears to be out of date!";
				public static LocString MOD_UPDATE_ALL = "Update {0:D} mods which appear to be out of date";
				public static LocString MOD_UPDATE_1 = "Update one mod which appears to be out of date";

				// Passive mode
				public static LocString OPTION_PASSIVE = "Passive Mode";

				// Steam update date
				public static LocString STEAM_UPDATE = "<b>Steam Updated:</b> {0:f}";

				// Steam update date not known
				public static LocString STEAM_UPDATE_UNKNOWN = "<b>Steam Updated</b>: Unknown";

				// Update results
				public static LocString UPDATE_ERROR = "<b>{0}</b>: <color=#FF0000>{1}</color>\n";
				public static LocString UPDATE_SINGLE = "<b>{0}</b>: <color=#00CC00>Updated</color>\n";
				public static LocString UPDATE_OK_CONFIG = "<b>{0}</b>: <color=#00CC00>{1:D} custom mod option files backed up</color>\n";
				public static LocString UPDATE_OK_CONFIG_1 = "<b>{0}</b>: <color=#00CC00>One custom mod option file backed up</color>\n";
				public static LocString UPDATE_OK_NOCONFIG = "<b>{0}</b>: <color=#FFCC00>Unable to back up configuration files</color>\n";
				public static LocString UPDATE_REST = "<b>{0:D}</b> <color=#00CC00>mods were updated with no errors</color>\n";
				public static LocString UPDATE_REST_1 = "<b>One</b> <color=#00CC00>mod was updated with no errors</color>\n";

				public static LocString UPDATE_NODETAILS = "Uninstalled or not found on workshop";
				public static LocString UPDATE_INPROGRESS = "An update for another mod is already in progress.";
				public static LocString UPDATE_NOFILE = "No file found to download";
				public static LocString UPDATE_CANTSTART = "Unable to start download";
				public static LocString UPDATE_OFFLINE = "Cannot download in Offline Mode";

				public static LocString UPDATE_HEADER = "<size=16>Update results:</size>\n\n";
				public static LocString UPDATE_ONE = "This mod";
				public static LocString UPDATE_MULTIPLE = "These mods";
				public static LocString UPDATE_FOOTER_OK = "\n{0} will be updated on the next restart.";
				public static LocString UPDATE_FOOTER_CONFIG = "\n<b><color=#FFCC00>Back up any valuable mod configurations now manually!</color></b>";
				public static LocString UPDATE_FOOTER_ERROR = "\nCheck your connection, and that the mods directory has sufficient disk space and permissions.";
			}

			public static class TOOLTIPS {
				public static class MODUPDATER {
					public static LocString OPTION_MAINMENU = "If selected, a warning with the number of potentially\noutdated mods is shown in the main menu.";
					public static LocString OPTION_PASSIVE = "Experimental! Enables Passive Mode which automatically keeps all mods up to date in the background.";
				}
			}
		}
	}
}
