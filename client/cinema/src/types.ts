
export interface CinemaItem {
    Cinema_Id: number;
    CinemaName: string;
    CinemaCity: string;
}

export type FetchState = "idle" | "loading" | "loaded" | "failed";