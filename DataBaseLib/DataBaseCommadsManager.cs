﻿using DataBaseLib.Access;
using DataBaseLib.Commands;
using System.Data;

namespace DataBaseLib;

/// <summary>
/// Выполнение команд пользователя
/// </summary>
public class DataBaseCommadsManager
{
    public DataTable GetDataTable(string tableName)
    {
        BaseCommands command = new BaseCommands();
        return command.GetDataTable(tableName);
    }

    public void Insert(string[] args, string tableName)
    {
        ITableEditorCommand command;
        switch (tableName)
        {
            case "Основная":
                command = new Table1Commands();
                break;
            case "Жанр":
                command = new Table2Commands();
                break;
            case "Режим":
                command = new Table3Commands();
                break;
            case "Название":
                command = new Table4Commands();
                break;
            case "Студия":
                command = new Table5Commands();
                break;
            default: throw new Exception("Ошибка!");
        }
        command.Insert(args);
    }

    public void Delete(string[] args, string tableName)
    {
        ITableEditorCommand command;
        switch (tableName)
        {
            case "Основная":
                command = new Table1Commands();
                break;
            case "Жанр":
                command = new Table2Commands();
                break;
            case "Режим":
                command = new Table3Commands();
                break;
            case "Название":
                command = new Table4Commands();
                break;
            case "Студия":
                command = new Table5Commands();
                break;
            default: throw new Exception("Ошибка!");
        }
        command.Delete(args);
    }

    public void Update(string[] args, string tableName)
    {
        ITableEditorCommand command;
        switch (tableName)
        {
            case "Основная":
                command = new Table1Commands();
                break;
            case "Жанр":
                command = new Table2Commands();
                break;
            case "Режим":
                command = new Table3Commands();
                break;
            case "Название":
                command = new Table4Commands();
                break;
            case "Студия":
                command = new Table5Commands();
                break;
            default: throw new Exception("Ошибка!");
        }
        command.Update(args);
    }
}