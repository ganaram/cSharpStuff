chmod 777 Project.cs
mcs -out:Project.exe Project.cs

file=Project.exe

if [[ -f "$file" ]];
	then
		mono "$file"
	else
		echo "No se ha compliado correctamente."
fi
