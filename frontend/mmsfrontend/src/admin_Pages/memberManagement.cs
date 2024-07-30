
/* Main Content Styles */
main {
    flex: 1;
    padding: 20px;
    width: 100%;
}

.title {
    text-align: center;
    color: #4CAF50;
    margin: 20px 0;
}

.buttons {
    display: flex;
    justify-content: flex-end;
    margin-bottom: 10px;
}

.editButton, .deleteButton, .saveButton {
    padding: 10px 20px;
    background-color: #f1f1f1;
    border: 1px solid #ccc;
    border-radius: 4px;
    cursor: pointer;
    margin-left: 10px;
}

.editButton:hover, .deleteButton:hover, .saveButton:hover {
    background-color: #ddd;
}

/* Table Styles */
.memberTable {
    width: 100%;
    border-collapse: collapse;
}

.memberTable th, .memberTable td {
    border: 1px solid #ccc;
    padding: 10px;
    text-align: left;
}

/* Action Button Styles */
.memberTable td button {
    padding: 5px 10px;
    border-radius: 4px;
    margin-right: 5px; /* Space between buttons */
}

.memberTable td .editButton {
    background-color: #9a9b9a;
    color: rgb(77, 76, 76);
    border: none;
}

.memberTable td .saveButton {
    background-color: #4CAF50;
    color: white;
    border: none;
}

.memberTable td .deleteButton {
    background-color: red;
    color: white;
    border: none;
}
