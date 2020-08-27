import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ItemCmpComponent } from './item-cmp.component';

describe('ItemCmpComponent', () => {
  let component: ItemCmpComponent;
  let fixture: ComponentFixture<ItemCmpComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ItemCmpComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ItemCmpComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
