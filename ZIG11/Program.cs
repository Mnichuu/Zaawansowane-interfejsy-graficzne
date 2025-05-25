using System;
using System.Collections.Generic;
using System.Collections;
using System.Diagnostics;
using System.Text;

public class GenericTypesDemo {
    private Queue<string> queue = new();
    private List<string> vector = new(); // Wektor = List w C#
    private LinkedList<string> list = new();
    private Dictionary<string, string> map = new();
    private HashSet<string> set = new();
    private Dictionary<string, string> dictionary = new();

    public void AddToType(string type, string key, string value = null) {
        Trace.WriteLine($"[Przed dodaniem] {type}: {GetContents(type)}");
        Debug.WriteLine($"[Przed dodaniem] {type}: {GetContents(type)}");

        switch (type.ToLower()) {
            case "queue":
                queue.Enqueue(key);
                break;
            case "vector":
                vector.Add(key);
                break;
            case "list":
                list.AddLast(key);
                break;
            case "map":
                if (!map.ContainsKey(key))
                    map.Add(key, value ?? key);
                break;
            case "set":
                set.Add(key);
                break;
            case "dictionary":
                if (!dictionary.ContainsKey(key))
                    dictionary.Add(key, value ?? key);
                break;
        }

        Trace.WriteLine($"[Po dodaniu] {type}: {GetContents(type)}");
        Debug.WriteLine($"[Po dodaniu] {type}: {GetContents(type)}");
    }

    public string GetAllContents() {
        var sb = new StringBuilder();
        sb.AppendLine("Queue: " + string.Join(", ", queue));
        sb.AppendLine("Vector: " + string.Join(", ", vector));
        sb.AppendLine("List: " + string.Join(", ", list));
        sb.AppendLine("Map: " + string.Join(", ", map.Select(kv => $"{kv.Key}:{kv.Value}")));
        sb.AppendLine("Set: " + string.Join(", ", set));
        sb.AppendLine("Dictionary: " + string.Join(", ", dictionary.Select(kv => $"{kv.Key}:{kv.Value}")));
        return sb.ToString();
    }

    public void RemoveFromType(string type, string key = null) {
        Trace.WriteLine($"[Przed usunięciem] {type}: {GetContents(type)}");
        Debug.WriteLine($"[Przed usunięciem] {type}: {GetContents(type)}");

        switch (type.ToLower()) {
            case "queue":
                if (queue.Count > 0)
                    queue.Dequeue();
                break;
            case "vector":
                if (vector.Count > 0)
                    vector.RemoveAt(vector.Count - 1);
                break;
            case "list":
                if (list.Count > 0)
                    list.RemoveLast();
                break;
            case "map":
                if (map.Count > 0 && key != null && map.ContainsKey(key))
                    map.Remove(key);
                break;
            case "set":
                if (set.Count > 0 && key != null)
                    set.Remove(key);
                break;
            case "dictionary":
                if (dictionary.Count > 0 && key != null && dictionary.ContainsKey(key))
                    dictionary.Remove(key);
                break;
        }

        Trace.WriteLine($"[Po usunięciu] {type}: {GetContents(type)}");
        Debug.WriteLine($"[Po usunięciu] {type}: {GetContents(type)}");
    }

    private string GetContents(string type) {
        return type.ToLower() switch {
            "queue" => string.Join(", ", queue),
            "vector" => string.Join(", ", vector),
            "list" => string.Join(", ", list),
            "map" => string.Join(", ", map.Select(kv => $"{kv.Key}:{kv.Value}")),
            "set" => string.Join(", ", set),
            "dictionary" => string.Join(", ", dictionary.Select(kv => $"{kv.Key}:{kv.Value}")),
            _ => ""
        };
    }
}
public class Program {
    public static void Main(string[] args) {
        Trace.Listeners.Add(new ConsoleTraceListener());

        var demo = new GenericTypesDemo();

        Console.WriteLine("Wybierz typ: queue, vector, list, map, set, dictionary");
        string type = Console.ReadLine();

        Console.WriteLine("Wpisz operację: add lub remove");
        string operation = Console.ReadLine();

        Console.WriteLine("Podaj klucz (lub wartość):");
        string key = Console.ReadLine();

        string value = null;
        if (type == "map" || type == "dictionary") {
            Console.WriteLine("Podaj wartość:");
            value = Console.ReadLine();
        }

        if (operation == "add") {
            demo.AddToType(type, key, value);
        } else if (operation == "remove") {
            demo.RemoveFromType(type, key);
        }

        Console.WriteLine("Aktualna zawartość wszystkich typów:");
        Console.WriteLine(demo.GetAllContents());

        Console.WriteLine("Naciśnij dowolny klawisz, aby zakończyć...");
        Console.ReadKey();
    }
}