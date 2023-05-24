
```ps1
cat (Get-PSReadlineOption).HistorySavePath

nircmd monitor off detectmove

rclone sync "C:/" "Z:/c" -v --ignore-errors --progress --links
rclone sync "/" "/mnt/x/y/z" -v --ignore-errors --progress --links
rclone move "C:/x" "Z:/x" -v --ignore-errors --progress --links

```

---

## detail '%AppData%\Microsoft\Internet Explorer\Quick Launch\User Pinned\TaskBar' historically

< The folder '%AppData%\Microsoft\Internet Explorer\Quick Launch\User Pinned\TaskBar' historically refers to a location in the Windows operating system where user-pinned items were stored on the taskbar. However, it is important to note that this folder has undergone changes in recent versions of Windows, and its functionality has been replaced by a different approach.

In previous versions of Windows, such as Windows 7 and earlier, the taskbar in Windows Explorer had a Quick Launch toolbar where users could pin frequently used applications and shortcuts for quick access. The '%AppData%\Microsoft\Internet Explorer\Quick Launch\User Pinned\TaskBar' folder was the location where these pinned items were stored. Each pinned item was represented by a shortcut file with the extension '.lnk'.

When a user pinned an item to the taskbar, Windows would create a shortcut file in the '%AppData%\Microsoft\Internet Explorer\Quick Launch\User Pinned\TaskBar' folder. This folder was typically located within the user's profile directory, specifically in the 'AppData' folder, which is a hidden system folder. The '%AppData%' portion of the path represents the user's AppData folder, which is typically located at 'C:\Users\Username\AppData\Roaming', where 'Username' is the name of the user account.

The Quick Launch folder and its associated user-pinned items remained intact until Windows 7. With the release of Windows 8, Microsoft introduced a new taskbar and Start menu design, eliminating the Quick Launch toolbar. Instead, they introduced a new way of pinning applications and shortcuts directly to the taskbar.

In the newer versions of Windows, including Windows 8, Windows 8.1, and Windows 10, the user-pinned items are stored in a different location. The taskbar pins and other taskbar-related settings are now stored in a database file called 'IconStreams' located at '%AppData%\Microsoft\Internet Explorer\Quick Launch\User Pinned\TaskBar'. This file contains binary data representing the taskbar layout and pinned items.

It's important to note that the '%AppData%\Microsoft\Internet Explorer\Quick Launch\User Pinned\TaskBar' folder is still present in newer versions of Windows for backward compatibility, but it no longer serves the same purpose as it did in earlier versions. The new taskbar design allows users to pin items directly to the taskbar without using the Quick Launch folder.
