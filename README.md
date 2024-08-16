
Voici l'exercice fini. j'ai pu développer un back en java springboots, et en asp.net, et relier le front aux deux
# Création de la base de données:

1) La base de données selectionnée est postgresql. Installez postgres en suivant ce lien : https://www.postgresql.org/
2) Une fois installé, vous pouvez ouvrir PgAdmin.

3) renseignez le mot de passe "admin"

4) Créez une base de donnée nommée "product-trial-feat"

5) Ouvrez Query tool :

   ![image](https://github.com/user-attachments/assets/00a3c82a-64e8-43fe-a6bc-8de98018d4ad)

7) Collez-y le contenu du fichier backup.sql situé à la racine puis executez
   ![image](https://github.com/user-attachments/assets/24e43736-ac76-4b99-933e-bcd64e8fd17b)

La base de donnée est à présent créée. Son adresse par défaut est "localhost:5432"


# Lancement du back Java Springboot

1) Sur votre ide (ici intellij) importez le dossier back java/Product-trial-feat
2) Vérifiez le fichier src/main/ressources/application.properties. Vérifiez qu'il contient bien l'url de la base de donnée au format "jdbc:postgresql://[host]/[database] ainsi que le nom d'utilisateur et le mot de passe correct
   ![image](https://github.com/user-attachments/assets/62ebfb7a-28f7-4f55-b3d2-29058781744d)

4) Démarrez le projet
   ![image](https://github.com/user-attachments/assets/72d219cd-ad47-4216-aeff-f924d9674889)

6) Si le projet ne démarre pas, veuillez tenter de syncrhroniser les dépendances et de faire un maven install
     ![image](https://github.com/user-attachments/assets/8b91d90c-2118-4222-80d2-da1c950ee88b)
   
7) Testez cette adresse : http://localhost:8080/product. Si le serveur est en marche, vous obtiendrez la liste des produits
   ![image](https://github.com/user-attachments/assets/6bba2d5c-40b7-4502-a2a2-40cc8ca450de)

# Lancement du back en c#

Le back en c# contient une implémentation de swagger. si jamais vous voulez le lancer, suivez cette procédure

1) Ouvrez back c#\back\back.sln avec visual studio
2) ouvrez propriété de débogage de back
   ![image](https://github.com/user-attachments/assets/79ed427d-4888-4ad7-a867-d7c45cbca570)
3)



