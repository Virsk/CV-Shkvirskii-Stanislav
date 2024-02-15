import { Appellation } from "./appellation";

export interface Content {
  appellations: Appellation[];
  title: string;
  descriptions: string[];
}
