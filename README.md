Ma solution WinForm fait une copie de la BD initiale dans son répertoire WindowsFormsApp/bin/Debug (Comportement naturel).
Des fois, Visual Studio supprime cette copie et du coup la solution n'arrive plus à atteindr la base ... 
Solution : il suffit de copier la DB localisé dans Service_DA/Database.mdf et de la coller dans le dossier WindowsFormsApp/bin/Debug.

Respectueusement, Antoine.
