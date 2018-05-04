import { Component } from '@angular/core';
import { MatTableDataSource } from '@angular/material';
import { DrawGames } from './mock-drawgame';

@Component({
    selector: 'app-drawgame',
    styleUrls: ['./drawgame.component.scss'],
    templateUrl: './drawgame.component.html'
})

export class DrawGameComponent {

    displayedColumns = ['id', 'title'];
    dataSource = new MatTableDataSource(this.drawGame.getDrawGames());

    constructor(public drawGame: DrawGames) {

    }
}
