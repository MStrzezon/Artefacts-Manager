USE artefacts_manager_database;

INSERT INTO `roles` VALUES (1,'admin'),(2,'creator'),(3,'editor'); 
INSERT INTO `users` VALUES (1,'admin',MD5('admin'),1),(2,'creator',MD5('creator'),2),(3,'editor',MD5('editor'),3);
INSERT INTO `permissions` VALUES (1,'All categories','All types',1,1,1),(2,'All categories','All types',1,0,1),(3,'All categories','All types',1,1,0);
INSERT INTO `rolespermissions` VALUES (1,1),(2,2),(3,3);
INSERT INTO `categories` VALUES (1,'wieza'),(2,'zagajnik'),(3,'jaskinia');
INSERT INTO `artefactstypes` VALUES (8,'mag'),(9,'ent');
INSERT INTO `attributes` VALUES (7,'poziom mocy'),(8,'krąg'),(9,'gatunek');
INSERT INTO `attributesartefactstypes` VALUES (8,7),(8,8),(9,7),(9,9);
INSERT INTO `artefacts` VALUES (1,'Drago',2,'2022-05-25 16:42:51',8,3),(2,'Milten',2,'2022-05-25 16:43:13',8,2),(3,'Myxir',2,'2022-05-25 16:43:33',8,1),(4,'Finglas',2,'2022-05-25 16:44:53',9,2),(5,'Fladrif',2,'2022-05-25 16:45:11',9,1),(6,'Drzewiec',2,'2022-05-25 16:45:38',9,3),(7,'Bregalad',2,'2022-05-25 16:46:10',9,3);
INSERT INTO `artefactsattributes` VALUES (1,7,'100'),(1,8,'x'),(2,7,'99'),(2,8,'y'),(3,7,'88'),(3,8,'z'),(4,7,'22'),(4,9,'x'),(5,7,'33'),(5,9,'y'),(6,7,'110'),(6,9,'m'),(7,7,'76'),(7,9,'n');
