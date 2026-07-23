import type { CinemaItem } from "../types";
import { useState } from "react";

interface CinemaSearchBarProps {
    cinemas: CinemaItem[];
}

const [query, setQuery] = useState("");
const [isOpen, setIsOpen] = useState(false);

export function CinemaSearchBar ({cinemas }: CinemaSearchBarProps) {

    // Filtering values
    const filteredItems = cinemas.filter((item) => 
        item.CinemaName.toLowerCase().includes(query.toLowerCase()));

    return (
        <div className="Cinema-Search-Container">
            <input type="text" className="Cinema-Search-Input"
            placeholder="Your cinema"
            value={query}
            onChange={(e) => {
                setQuery(e.target.value);
                setIsOpen(true);}}
                onFocus={() => setIsOpen(true)} />
            {isOpen && filteredItems.length > 1 && (
                <ul className="Cinema-Search-Options">
                    
                    {filteredItems.map((item) => (
                        <li className="Cinema-Search-Option-Row"
                        key={item.Cinema_Id}
                        onClick={() => {
                            setQuery(item.CinemaName);
                            setIsOpen(false);
                        }}>
                            {item.CinemaName}
                        </li>
                    ))}
                </ul>
            )}
            <button type="button" className="Cinema-Search-Button">Seleccionar</button>
        </div>
    )
}