CREATE DEFINER = CURRENT_USER TRIGGER `Team10`.`Customer_BEFORE_UPDATE` BEFORE UPDATE ON `Customer` FOR EACH ROW
# If you change the code below, reflect the changes in Customer_BEFORE_INSERT and Customer_BEFORE_UPDATE
BEGIN
	# Verifies there are 0 matches for email in DB
	IF 0 <> (SELECT COUNT(*) FROM `Team10`.`Customer` AS C WHERE C.Email = NEW.Email LIMIT 1) THEN
		# throws an error and cancels the insertion
		SIGNAL SQLSTATE '45000'
		SET MESSAGE_TEXT = 'That email address is already in use, please select another email.';
    END IF;
END