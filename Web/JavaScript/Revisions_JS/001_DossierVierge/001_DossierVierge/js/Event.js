class Event{
    static collection;
    static sortDirection = true; 

    static columnSort(e){
        Event.collection.sortCollection(e.target.dataset[name], Event.sortDirection);
        Event.sortDirection = !Event.sortDirection;
    }
}

export {Event}