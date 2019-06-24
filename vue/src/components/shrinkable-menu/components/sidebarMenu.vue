
<style lang="less">
    @import '../styles/menu.less';
</style>

<template>
    <Menu ref="sideMenu" :active-name="$route.name" hide-trigger collapsible :collapsed-width="78" v-model="isCollapsed" :open-names="openNames" :theme="menuTheme" width="auto" @on-select="changeMenu">
        <template v-for="item in menuList">
            <MenuItem v-if="item.children.length<=0" :name="item.children[0].name" :key="item.name">
                <!-- <Icon :type="item.icon" :size="iconSize"></Icon> -->
                <span class="iconfont">{{item.icon}}</span>
                <span>{{ itemTitle(item) }}</span>
            </MenuItem>
            <Submenu v-if="item.children.length > 0" :name="item.name" :key="item.name">
                <template slot="title">
                    <i class="iconfont" v-html="item.icon"></i>
                    <span >{{ itemTitle(item) }}</span>
                </template>
                <template v-for="child in item.children">
                    <MenuItem :name="child.name" :key="child.name"> 
                        <i class="iconfont" v-html="child.icon"></i>                       
                        <span>{{ L(child.meta.title) }}</span>
                    </MenuItem>
                </template>
            </Submenu>
        </template>
    </Menu>
</template>

<script lang="ts">
import { Component, Vue,Inject,Prop,Emit } from 'vue-property-decorator';
import AbpBase from '../../../lib/abpbase'
@Component({})
export default class SidebarMenu extends AbpBase {
     isCollapsed = false;
    name:string='sidebarMenu';
    @Prop({type:Array}) menuList:Array<any>;
    @Prop({type:Number}) iconSize:number;
    @Prop({type:String,default:'dark'}) menuTheme:string;
    @Prop({type:Array}) openNames:Array<string>;
     
    itemTitle(item:any):string{
        return this.L(item.meta.title);
    }
    @Emit('on-change')
    changeMenu(active:string){
    }
    updated () {
        
    console.log(this.menuList);
        this.$nextTick(() => {
            if (this.$refs.sideMenu) {
                (this.$refs.sideMenu as any).updateActiveName();
            }
        });
    }

    rotateIcon () {
                return [
                    'menu-icon',
                    this.isCollapsed ? 'rotate-icon' : ''
                ];
            }
            menuitemClasses () {
                return [
                    'menu-item',
                    this.isCollapsed ? 'collapsed-menu' : ''
                ]
            } 

}
</script>
<style scoped>
    .layout{
        border: 1px solid #d7dde4;
        background: #f5f7f9;
        position: relative;
        border-radius: 4px;
        overflow: hidden;
    }
    .layout-header-bar{
        background: #fff;
        box-shadow: 0 1px 1px rgba(0,0,0,.1);
    }
    .layout-logo-left{
        width: 90%;
        height: 30px;
        background: #5b6270;
        border-radius: 3px;
        margin: 15px auto;
    }
    .menu-icon{
        transition: all .3s;
    }
    .rotate-icon{
        transform: rotate(-90deg);
    }
    .menu-item span{
        display: inline-block;
        overflow: hidden;
        width: 69px;
        text-overflow: ellipsis;
        white-space: nowrap;
        vertical-align: bottom;
        transition: width .2s ease .2s;
    }
    .menu-item i{
        transform: translateX(0px);
        transition: font-size .2s ease, transform .2s ease;
        vertical-align: middle;
        font-size: 16px;
    }
    .collapsed-menu span{
        width: 0px;
        transition: width .2s ease;
    }
    .collapsed-menu i{
        transform: translateX(5px);
        transition: font-size .2s ease .2s, transform .2s ease .2s;
        vertical-align: middle;
        font-size: 22px;
    }
   
</style>
<style>
 .ivu-btn-text:active, .ivu-btn-text.active,.ivu-btn-text:hover{
        color: #2b85e4 !important;
        background-color: #2b85e4 !important;
        border-color:initial !important;
        border: initial !important;
         outline:none !important;
    }
    #naCli:active,#naCli:hover{
        color: initial !important;
        background-color: initial !important;
        border-color:initial !important;
        border: initial !important;
         outline:none !important;
    }
    #naCli:focus{
        -webkit-box-shadow:none!important;
        box-shadow:none !important;
         outline:none !important;
    }
    #naCli:not([disabled]):active{
        outline:none !important;
    }
    /*优化标签页错位问题*/
    .ivu-tag-blue{
        line-height: 32px !important;
    }
</style>
